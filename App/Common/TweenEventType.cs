//  
//  TweenEventType.cs
//  
//  Author:
//       rihine <ned.rihine@gmail.com>
// 
//  Copyright (c) 2011 rihine
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
using System;


namespace Tween {
    
    
    /**
     *
     */
    [FlagsAttribute]
    public enum TweenEventType {
        None              = 2 << 0,
        Favorite          = 2 << 1,
        UnFavorite        = 2 << 2,
        Follow            = 2 << 3,
        ListMemberAdded   = 2 << 4,
        ListMemberRemoved = 2 << 5,
        Block             = 2 << 6,
        Unblock           = 2 << 7,

        All = Favorite | UnFavorite | Follow | ListMemberAdded | ListMemberRemoved | Block | Unblock
    }


}
