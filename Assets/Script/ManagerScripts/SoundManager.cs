using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

[System.Serializable]
public class Clip
{
    public string Name;
    public AudioClip clip;
}
public class SoundManager : Singleton<SoundManager>
{
    public AudioSource audioSource;
    public List<Clip> clips;
    public Button BGMBar;
    public Button SFXBar;
    public bool On = true;
    public bool SFXOn = true;

    float SEvolume = 1;
    protected SoundManager() { }

    
    public Slider slider;
    public Text text;
    float Value = 1;
    int p = 100;

    public void Playbgm(string name)
    //사용법 Sound.Instance.ChangeClip("이름",루프 할껀지안할껀지(bool))
    {
        Clip find = clips.Find((o) => { return o.Name == name; });
        if (find != null)
        {
            audioSource.Stop();
            audioSource.clip = find.clip;
            audioSource.loop = true;
            audioSource.Play();

        }
    }

    public void PlaySound(string _clip)
    {
        Clip find = clips.Find((o) => { return o.Name == _clip; });
        if (find != null)
        {
            GameObject audio_object = new GameObject();
            AudioSource object_source = audio_object.AddComponent<AudioSource>();
            object_source.volume = SEvolume;
            object_source.clip = find.clip;
            object_source.loop = false;
            object_source.Play();

            Destroy(audio_object, find.clip.length);
        }
    }
    public void PlaySound(AudioClip _clip)
    {
        GameObject audio_object = new GameObject();
        AudioSource object_source = audio_object.AddComponent<AudioSource>();
        object_source.volume = SEvolume;
        object_source.clip = _clip;
        object_source.loop = false;
        object_source.Play();

        Destroy(audio_object, _clip.length);
    }

    public void SetMusicVolume(float volume)
    {
        audioSource.volume = volume;
    }
    public void SetSEVolume(float volume)
    {
        SEvolume = volume;
    }


    public void Slider_right()
    {
        if (Value < 1)
        {
            Value += 0.1f;
            p += 10;

        }
        else
        {
            Value = 0;
            p = 0;
        }
        text.text = p.ToString() + "%";
        slider.GetComponent<Slider>().value = Value;
    }

    public void Slider_left()
    {
        if (Value >= 0.1f)
        {
            Value -= 0.1f;
            p -= 10;
        }else if(Value < 0.1f)
        {
            Value = 0;
            p = 0;
        }
        text.text = p.ToString() + "%";
        slider.GetComponent<Slider>().value = Value;
    }
}
