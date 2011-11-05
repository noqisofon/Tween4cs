//  
//  AbstractApiInfo.cs
//  
//  Author:
//       rihine <ned.rihine@gmail.com>
// 
//  Copyright (c) 2011 rihine All rights reserved.
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


namespace Tween.Extensions {


    /**
     * 
     */
    public abstract class AbstractApiInformation {
        /**
         * 
         */
        protected AbstractApiInformation() {
        }


        protected static int __max_count = -1;
        protected static int __remain_count = -1;
        protected static DateTime __reset_time = DateTime.Now;
        protected static int __reset_time_in_seconds = -1;
        protected static int __using_count = -1;
        protected static ApiAccessLevel __access_level = ApiAccessLevel.None;
        protected static int __media_max_count = -1;
        protected static DateTime __media_reset_time = DateTime.Now;
        protected static int __media_remain_count = -1;
    }


}
