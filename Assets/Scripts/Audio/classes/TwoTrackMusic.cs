using Base.Audio;
using UnityEngine;

/// <summary>
/// 双音轨音乐资源，由一条平缓音轨和一条激昂音轨组合而成。
/// <c>（平缓状态下只播放平缓音轨，当音乐系统要求音乐变得激烈时会淡入叠加播放激昂音轨）</c>
/// </summary>
public class TwoTrackMusic : MusicAssetBase
{
    [SerializeField]
    private AudioSequence baseTrack;
    [SerializeField]
    private AudioSequence intenseTrack;

    private string baseAudioHandleID, intenseAudioHandleID;

    #region Public 方法
    public override void Play()
    {

    }

    public override void Pause()
    {

    }

    public override void Stop()
    {

    }

    public override void GoIntense()
    {

    }

    public override void GoCalm()
    {

    }
    #endregion

    private void OnDestroy()
    {
        AudioManager.Free(baseAudioHandleID);
        AudioManager.Free(intenseAudioHandleID);
    }
}