﻿using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceView
{
public class Doctor
{
    /// <summary>
    /// Gets or sets the resource name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the resource id.
    /// </summary>
    public object Id { get; set; }

    /// <summary>
    /// Gets or sets the resource background brush.
    /// </summary>
    public Brush BackgroundBrush { get; set; }

    /// <summary>
    /// Gets or sets the foreground brush.
    /// </summary>
    public Brush ForegroundBrush { get; set; }

}

    /// <summary>
    /// Represents a class that defines the scheduler resource collection.
    /// </summary>
    public class SchedulerResourceCollection : ObservableCollection<object>
    {

    }
}
