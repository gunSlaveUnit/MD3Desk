using System;
using System.Collections.Generic;
using System.IO;
using MD3Desk.ViewModels.Base;

namespace MD3Desk.ViewModels.MainWindow;

public class AssemblyViewModel : Child<MainViewModel>
{
    #region Properties

    private const String VideosPath = "Resources/Videos";

    #region Videos
    
    #region Videos
    
    private List<String> _videos;
    
    public List<String> Videos
    {
        get => _videos;
        private set => Set(ref _videos, value);
    }
    
    #endregion

    #endregion

    #endregion
    
    public AssemblyViewModel (MainViewModel parent)
    {
        Parent = parent;

        Videos = new List<string>
        {
            Path.Combine(VideosPath, "1.wmv"),
            Path.Combine(VideosPath, "2.wmv"),
            Path.Combine(VideosPath, "3.wmv"),
            Path.Combine(VideosPath, "4.wmv"),
        };
    }
}