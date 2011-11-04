//  
//  PostingStatus.cs
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


namespace Tween.Widgets {


    /**
     *
     */
    internal class PostingStatus {
        /**
         * 
         */
        public PostingStatus() : this(string.Empty, 0, string.Empty, string.Empty, string.Empty) {
        }
        /**
         * 
         */
        public PostingStatus(string status, long reply_to_id, string reply_to_name) : this(status, reply_to_id, reply_to_name, string.Empty, string.Empty) {
        }
        /**
         * 
         */
        public PostingStatus(string status, long reply_to_id, string reply_to_name, string image_service, string image_path) {
            this.status_ = status;
            this.reply_to_id_ = reply_to_id;
            this.reply_to_name_ = reply_to_name;
            this.image_service_ = image_service;
            this.image_path_ = image_path;
        }


        /**
         * 
         */
        public string Status {
            get { return this.status_; }
        }


        /**
         * 
         */
        public long InReplyToId {
            get { return this.reply_to_id_; }
        }


        /**
         * 
         */
        public string InReplToName {
            get { return this.reply_to_name_; }
        }


        /**
         * 
         */
        public string ImageService {
            get { return this.mage_service_; }
        }


        /**
         * 
         */
        public string ImagePath {
            get { return this.image_path_; }
        }


        private string status_;
        private long reply_to_id_;
        private string reply_to_name_;
        private string image_service_;
        private string image_path_;
    }


}
