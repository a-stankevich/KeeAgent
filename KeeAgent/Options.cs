﻿//
//  Options.cs
//
//  Author(s):
//      David Lechner <david@lechnology.com>
//
//  Copyright (C) 2012-2013  David Lechner
//
//  This program is free software; you can redistribute it and/or
//  modify it under the terms of the GNU General Public License
//  as published by the Free Software Foundation; either version 2
//  of the License, or (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, see <http://www.gnu.org/licenses>

using System;
using dlech.SshAgentLib;

namespace KeeAgent
{
  [Serializable]
  public class Options
  {
    public Options()
    {
      /* set default values */
    }

    /// <summary>
    /// Show notification balloon when client uses key (Agent mode only)
    /// </summary>
    public bool ShowBalloon { get; set; }

    /// <summary>
    /// Cause all keys to have confirm constraint set even if it is not requested (Agent mode only)
    /// </summary>
    public bool AlwaysConfirm { get; set; }

    /// <summary>
    /// Replaced by ShowBallon and AlwaysConfirm
    /// </summary>
    [Obsolete()]
    public NotificationOptions Notification { get; set; }

    /// <summary>
    /// Turns on debug logging - currently not working
    /// </summary>
    public bool LoggingEnabled { get; set; }

    /// <summary>
    /// The file name for the debug log file
    /// </summary>
    public string LogFileName { get; set; }

    /// <summary>
    /// Specifies which mode to run the agent in.
    /// </summary>
    public AgentMode AgentMode { get; set; }
  }
}
