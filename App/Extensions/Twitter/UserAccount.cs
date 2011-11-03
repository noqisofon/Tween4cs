//  
//  UserAccount.cs
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


namespace Tween.Extensions.Twitter {
    
    
    public class UserAccount {
        public UserAccount () {
        }
        
        public string Username {
            get { return string.user_name_; }
        }
        
        
        public long UserId {
            get { return this.user_id_; }
            set { this.user_id_ = value; }
        }
        
        
        public string Token {
            get { return this.access_token_; }
        }
        
        
        public string TokenSecret {
            get { return this.access_secret_token_; }
        }
        
        private string user_name_;
        private long user_id_;
        private string access_token_;
        private string access_secret_token_;
    }


}
