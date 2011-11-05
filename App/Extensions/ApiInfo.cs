//  
//  ApiInfo.cs
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
     * Api 情報のスナップショット。
     */
    public class ApiInfo : AbstractApiInformation {
        /**
         * 
         */
        public ApiInfo() {
            this.max_count_ = __max_count;
            this.remain_count_ = __remain_count;
            this.reset_time_ = __reset_time;
            this.reset_time_in_seconds_ = __reset_time_in_seconds;
            this.using_count_ = __using_count;
            this.access_level_ = __access_level;
            this.media_max_count_ = __media_max_count;
            this.media_reset_time_ = __media_reset_time;
            this.media_remain_count_ = __media_remain_count;
        }


        /**
         * 
         */
        public  int MaxCount {
            get { return this.max_count_; }
        }


        /**
         * 
         */
        public  int RemainCount {
            get { return this.remain_count_; }
        }


        /**
         * 
         */
        public  DateTime ResetTime {
            get { return this.reset_time_; }
        }


        /**
         * 
         */
        public  int ResetTimeInSeconds {
            get { return this.reset_time_in_seconds_; }
        }


        /**
         * 
         */
        public  int UsingCount {
            get { return this.using_count_; }
        }


        /**
         * 
         */
        public  ApiAccessLevel AccessLevel {
            get { return this.access_level_; }
        }


        /**
         * 
         */
        public  int MediaMaxCount {
            get { return this.media_max_count_; }
        }


        /**
         * 
         */
        public  DateTime MediaResetTime {
            get { return this.media_max_reset_time_; }
        }


        /**
         * 
         */
        public  int MediaRemainCount {
            get { return this.media_remain_count_; }
        }


        private int max_count_;
        private int remain_count_;
        private DateTime reset_time_;
        private int reset_time_in_seconds_;
        private int using_count_;
        private ApiAccessLevel access_level_;
        private int media_max_count_;
        private DateTime media_reset_time_;
        private int media_remain_count_;
    }


}
