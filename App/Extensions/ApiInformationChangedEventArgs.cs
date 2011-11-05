//  
//  ApiInformationChangedEventArgs.cs
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
    public class ApiInformationChangedEventArgs : EventArgs {
        /**
         * 
         */
        public ApiInformationChangedEventArgs(ApiInfo api_info) {
            this.api_info_ = api_info;
        }


        /**
         * 
         */
        public ApiInfo ApiInfo {
            get { return this.api_info_; }
        }


        private ApiInfo api_info_;
    }
    
    
    public delegate void ApiInformationChangedEventHandler(object sender, ApiInformationChangedEventArgs eargs);


}
