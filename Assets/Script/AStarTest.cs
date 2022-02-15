using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Node
{
    public Node(bool _isWall, int _x, int _y) { isWall = _isWall; x = _x; y = _y; }

    public bool isWall;
    public Node ParentNode;

    //G: �������κ��� �̵��ߴ� �Ÿ�,H : [����]+[����]��ֹ� �����Ͽ� ��ǥ������ �Ÿ�, F : G + H
    public int x, y, G, H;
    public int F { get { return G + H; } }

}
public class AStarTest : Singleton<AStarTest>
{
    public Vector2Int bottomLeft, topRight, startPos, targetPos;
    public List<Node> FinalNodeList;
    public bool allowDiagonal, dontCrossCorner;

    int sizeX, sizeY;
    Node[,] NodeArray;
    public Node StartNode, TargetNode, CurNode;
    private Vector2Int realBottomLeft, realTopRight;

    List<Node> OpenList, ClosedList;
    public Transform StartTR;

    public void PathFinding()
    {
        startPos = Vector2Int.RoundToInt(StartTR.position);
        realBottomLeft = startPos + bottomLeft;
        realTopRight = startPos + topRight;

        //NodeArray�� ũ�� �����ְ�, isWall, x, y ����
        sizeX = topRight.x - bottomLeft.x + 1;
        sizeY = topRight.y - bottomLeft.y + 1;
        NodeArray = new Node[sizeX, sizeY];

        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                bool isWall = false;
                foreach (Collider2D col in Physics2D.OverlapCircleAll(new Vector2(i + realBottomLeft.x, j + realBottomLeft.y), 0.4f))
                    if (col.gameObject.layer == LayerMask.NameToLayer("Wall")) isWall = true;

                NodeArray[i, j] = new Node(isWall, i + realBottomLeft.x, j + realBottomLeft.y);
            } 
        }
        // ���۰� �� ���, ��������Ʈ�� ���� ����Ʈ, ����������Ʈ �ʱ�ȭ
        StartNode = NodeArray[- bottomLeft.x,- bottomLeft.x];
        TargetNode = NodeArray[targetPos.x - realBottomLeft.x  , targetPos.y - realBottomLeft.y];

        OpenList = new List<Node>() { StartNode };
        ClosedList = new List<Node>();
        FinalNodeList = new List<Node>();

        while (OpenList.Count > 0)
        {
            //��������Ʈ �� ���� F�� �۰� F�� ���ٸ� H�� ���� �� ������� �ϰ� ���� ����Ʈ���� ���� ����Ʈ�� �ű��
            CurNode = OpenList[0];
            for (int i = 1; i < OpenList.Count; i++)
                if (OpenList[i].F <= CurNode.F && OpenList[i].H < CurNode.H) CurNode = OpenList[i];

            OpenList.Remove(CurNode);
            ClosedList.Add(CurNode);

            //������
            if (CurNode == TargetNode)
            {
                Node TargetCurNode = TargetNode;
                while (TargetCurNode != StartNode)
                {
                    FinalNodeList.Add(TargetCurNode);
                    TargetCurNode = TargetCurNode.ParentNode;
                }
                FinalNodeList.Add(StartNode);
                FinalNodeList.Reverse();

                //for (int i = 0; i < FinalNodeList.Count; i++) Debug.Log(i + "��°��" + FinalNodeList[i].x + "," + FinalNodeList[i].y);
                return;
            }

            //�밢�� �̵�
            if (allowDiagonal)
            {
                OpenListAdd(CurNode.x + 1, CurNode.y + 1);
                OpenListAdd(CurNode.x - 1, CurNode.y + 1);
                OpenListAdd(CurNode.x - 1, CurNode.y - 1);
                OpenListAdd(CurNode.x + 1, CurNode.y - 1);
            }
            //���� �̵�
            OpenListAdd(CurNode.x, CurNode.y + 1);
            OpenListAdd(CurNode.x, CurNode.y - 1);
            OpenListAdd(CurNode.x + 1, CurNode.y);
            OpenListAdd(CurNode.x - 1, CurNode.y);

        }
    }

    void OpenListAdd(int checkX, int checkY)
    {

        int realCheckX = checkX - startPos.x;
        int realCheckY = checkY - startPos.y;
        //Debug.Log(NodeArray[checkX - bottomLeft.x, checkY - bottomLeft.y].x + " " + NodeArray[checkX - bottomLeft.x, checkY - bottomLeft.y].y + " " + NodeArray[checkX - bottomLeft.x, checkY - bottomLeft.y].isWall);
        //�����¿� ������ ����� �ʰ�, ���� �ƴϸ鼭, ���� ����Ʈ�� ���ٸ�
        if (checkX >= realBottomLeft.x
            && checkX < realTopRight.x
            && checkY >= realBottomLeft.y
            && checkY < realTopRight.y
            && (!NodeArray[realCheckX - bottomLeft.x , realCheckY - bottomLeft.y ].isWall
            || NodeArray[realCheckX - bottomLeft.x , realCheckY - bottomLeft.y ] == TargetNode)
            && !ClosedList.Contains(NodeArray[realCheckX - bottomLeft.x , realCheckY - bottomLeft.y]))
        {
            //�밢�� ��ֹ� ���̷� ��������
            if (allowDiagonal)
                if (NodeArray[CurNode.x - bottomLeft.x, realCheckY - bottomLeft.y].isWall
                    || NodeArray[realCheckX - bottomLeft.x, CurNode.y - bottomLeft.y].isWall) return;
            // �밢�� ��ֹ� ������ ��������
            if (dontCrossCorner) if (NodeArray[CurNode.x - bottomLeft.x, realCheckY - bottomLeft.y].isWall
                     || NodeArray[realCheckX - bottomLeft.x, CurNode.y - bottomLeft.y].isWall) return;


            //�̿���忡 �ְ�, ������ 10, �밢���� 14 �ڽ�Ʈ 
            Node NeighborNode = NodeArray[realCheckX - bottomLeft.x, realCheckY - bottomLeft.y];
            int MoveCost = CurNode.G + (CurNode.x - checkX == 0 || CurNode.y - checkY == 0 ? 10 : 14);
            //�̵������ �̿����G���� �۰ų� �Ǵ� ��������Ʈ�� �̿���尡 ���ٸ� G,H,ParentNode�� ���� �� ���� ����Ʈ�� �߰�
            if (MoveCost < NeighborNode.G || !OpenList.Contains(NeighborNode))
            {
                NeighborNode.G = MoveCost;
                NeighborNode.H = (Mathf.Abs(NeighborNode.x - TargetNode.x) + Mathf.Abs(NeighborNode.y - TargetNode.y)) * 10;
                NeighborNode.ParentNode = CurNode;

                OpenList.Add(NeighborNode);
            }

        }

    }

    private void OnDrawGizmos()
    {
        if (FinalNodeList.Count != 0) for (int i = 0; i < FinalNodeList.Count - 1; i++)
                Gizmos.DrawLine(new Vector2(FinalNodeList[i].x, FinalNodeList[i].y), new Vector2(FinalNodeList[i + 1].x, FinalNodeList[i + 1].y));
    }

}
