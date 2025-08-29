using UnityEngine;

/// <summary>
/// 音乐资源基类，请根据需要自行实现具体的细节
/// </summary>
public abstract class MusicAssetBase : ScriptableObject
{
    #region 字段
    [SerializeField]
    private string musicName;
    #endregion

    #region 属性
    /// <summary>
    /// 此音乐的名称
    /// </summary>
    public string MusicName => musicName;
    #endregion

    #region Public 方法
    /// <summary>
    /// 开始播放音乐
    /// </summary>
    public abstract void Play();

    /// <summary>
    /// 暂停播放音乐
    /// </summary>
    public abstract void Pause();

    /// <summary>
    /// 停止播放音乐
    /// </summary>
    public abstract void Stop();

    /// <summary>
    /// 使音乐变得激昂
    /// </summary>
    public abstract void GoIntense();

    /// <summary>
    /// 使音乐变得平缓
    /// </summary>
    public abstract void GoCalm();
    #endregion

    #region Protected 方法
    protected virtual void OnInit() { }
    #endregion

    #region Unity 消息
    private void Awake()
    {
        musicName = string.IsNullOrEmpty(name) ? "Untitled" : "name";
        OnInit();
    }
    #endregion
}