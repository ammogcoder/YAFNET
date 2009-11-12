/* Yet Another Forum.net
 * Copyright (C) 2006-2009 Jaben Cargman
 * http://www.yetanotherforum.net/
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 */
namespace YAF.Classes.Utils
{
  using System;
  using System.Web.Profile;

  /// <summary>
  /// The yaf user profile.
  /// </summary>
  public class YafUserProfile : ProfileBase
  {
    /// <summary>
    /// Gets or sets Location.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("Location;nvarchar;255")]
    public string Location
    {
      get
      {
        return base["Location"] as string;
      }

      set
      {
        base["Location"] = value;
      }
    }

    /// <summary>
    /// Gets or sets Homepage.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("Homepage;nvarchar;255")]
    public string Homepage
    {
      get
      {
        return base["Homepage"] as string;
      }

      set
      {
        base["Homepage"] = value;
      }
    }

    /// <summary>
    /// Gets or sets MSN.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("MSN;nvarchar;255")]
    public string MSN
    {
      get
      {
        return base["MSN"] as string;
      }

      set
      {
        base["MSN"] = value;
      }
    }

    /// <summary>
    /// Gets or sets YIM.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("YIM;nvarchar;255")]
    public string YIM
    {
      get
      {
        return base["YIM"] as string;
      }

      set
      {
        base["YIM"] = value;
      }
    }

    /// <summary>
    /// Gets or sets AIM.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("AIM;nvarchar;255")]
    public string AIM
    {
      get
      {
        return base["AIM"] as string;
      }

      set
      {
        base["AIM"] = value;
      }
    }

    /// <summary>
    /// Gets or sets ICQ.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("ICQ;nvarchar;255")]
    public string ICQ
    {
      get
      {
        return base["ICQ"] as string;
      }

      set
      {
        base["ICQ"] = value;
      }
    }

    /// <summary>
    /// Gets or sets GoogleTalk.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("GoogleTalk;nvarchar;255")]
    public string GoogleTalk
    {
      get
      {
        return base["GoogleTalk"] as string;
      }

      set
      {
        base["GoogleTalk"] = value;
      }
    }

    /// <summary>
    /// Gets or sets Skype.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("Skype;nvarchar;255")]
    public string Skype
    {
      get
      {
        return base["Skype"] as string;
      }

      set
      {
        base["Skype"] = value;
      }
    }

    /// <summary>
    /// Gets or sets Blog.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("Blog;nvarchar;255")]
    public string Blog
    {
      get
      {
        return base["Blog"] as string;
      }

      set
      {
        base["Blog"] = value;
      }
    }

    /// <summary>
    /// Gets or sets BlogServiceUrl.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("BlogServiceUrl;nvarchar;255")]
    public string BlogServiceUrl
    {
      get
      {
        return base["BlogServiceUrl"] as string;
      }

      set
      {
        base["BlogServiceUrl"] = value;
      }
    }

    /// <summary>
    /// Gets or sets BlogServiceUsername.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("BlogServiceUsername;nvarchar;255")]
    public string BlogServiceUsername
    {
      get
      {
        return base["BlogServiceUsername"] as string;
      }

      set
      {
        base["BlogServiceUsername"] = value;
      }
    }

    /// <summary>
    /// Gets or sets BlogServicePassword.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("BlogServicePassword;nvarchar;255")]
    public string BlogServicePassword
    {
      get
      {
        return base["BlogServicePassword"] as string;
      }

      set
      {
        base["BlogServicePassword"] = value;
      }
    }

    /// <summary>
    /// Gets or sets RealName.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("RealName;nvarchar;255")]
    public string RealName
    {
      get
      {
        return base["RealName"] as string;
      }

      set
      {
        base["RealName"] = value;
      }
    }

    /// <summary>
    /// Gets or sets Occupation.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("Occupation;nvarchar;400")]
    public string Occupation
    {
      get
      {
        return base["Occupation"] as string;
      }

      set
      {
        base["Occupation"] = value;
      }
    }

    /// <summary>
    /// Gets or sets Interests.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("Interests;nvarchar;400")]
    public string Interests
    {
      get
      {
        return base["Interests"] as string;
      }

      set
      {
        base["Interests"] = value;
      }
    }

    /// <summary>
    /// Gets or sets Gender.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("Gender;int")]
    public int Gender
    {
      get
      {
        return (int) base["Gender"];
      }

      set
      {
        base["Gender"] = value;
      }
    }

    /// <summary>
    /// Gets or sets Birthday.
    /// </summary>
    [SettingsAllowAnonymous(false)]
    [CustomProviderData("Birthday;DateTime")]
    public DateTime Birthday
    {
      get
      {
        return (DateTime) base["Birthday"];
      }

      set
      {
        base["Birthday"] = value;
      }
    }

    /// <summary>
    /// Helper function to get a profile from the system
    /// </summary>
    /// <param name="userName">
    /// </param>
    /// <returns>
    /// </returns>
    public static YafUserProfile GetProfile(string userName)
    {
      return Create(userName) as YafUserProfile;
    }
  }
}