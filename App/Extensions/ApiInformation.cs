//  
//  ApiInformation.cs
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
    public class ApiInformation : AbstractApiInformation {
        /**
         * 
         */
        public int MaxCount {
            get { return __max_count; }
            set {
                if ( __max_count = value ) {
                    __max_count = value;
                    this.PerformChanged();
                }
            }
        }


        /**
         * 
         */
        public int RemainCount {
            get { return __remain_count; }
            set {
                if ( __remain_count = value ) {
                    __remain_count = value;
                    this.PerformChanged();
                }
            }
        }


        /**
         * 
         */
        public DateTime ResetTime {
            get { return __reset_time; }
            set {
                if ( __reset_time != value ) {
                    __reset_time = value;
                    this.PerformChanged();
                }
            }
        }


        /**
         * 
         */
        public int ResetTimeInSeconds {
            get { return __reset_time_in_seconds; }
            set {
                if ( __reset_time_in_seconds = value ) {
                    __reset_time_in_seconds = value;
                    this.PerformChanged();
                }
            }
        }


        /**
         * 
         */
        public int UsingCount {
            get { return __using_count; }
            set {
                if ( __using_count != value ) {
                    __using_count = value;
                    this.PerformChanged();
                }
            }
        }


        /**
         * 
         */
        public ApiAccessLevel AccessLevel {
            get { return __access_level; }
            set {
                if ( __access_level != value ) {
                    __access_level = value;
                    this.PerformChanged();
                }
            }
        }


        /**
         * 
         */
        public int MediaMaxCount {
            get { return __media_max_count; }
            set {
                if ( __media_max_count != value ) {
                    __media_max_count = value;
                    this.PerformChanged();
                }
            }
        }


        /**
         * 
         */
        public DateTime MediaResetTime {
            get { return __media_max_reset_time; }
            set {
                if ( __media_max_reset_time != value ) {
                    __media_max_reset_time = value;
                    this.PerformChanged();
                }
            }
        }


        /**
         * 
         */
        public int MediaRemainCount {
            get { return __media_remain_count; }
            set {
                if ( __media_remain_count != value ) {
                    __media_remain_count = value;
                    this.PerformChanged();
                }
            }
        }


        /**
         * 
         */
        public event ApiInformationChangedEventHandler Changed;


        /**
         * 
         */
        public DateTime ConvertResettimeInSecondsToResetTime(int seconds) {
            if ( seconds >= 0 )
                TimeZone.CurrentTimeZone.ToLocalTime( new DateTime( 1970, 1, 1, 0, 0, 0 ) ).AddSeconds( seconds );
            else
                return DateTime.Now;
        }


        /**
         * 
         */
        public bool IsReadPermission {
            get {
                return this.AccessLevel == ApiAccessLevel.Read
                    || this.AccessLevel == ApiAccessLevel.ReadWrite
                    || this.AccessLevel == ApiAccessLevel.ReadWriteAndDirectMessage;
            }
        }


        /**
         * 
         */
        protected void PerformChanged() {
            ApiInformationChangedEventArgs eargs = new ApiInformationChangedEventArgs();

            if ( this.Changed != null ) {
                this.Changed( this, eargs );

                __max_count = eargs.ApiInfo.MaxCount;
                __remain_count = eargs.ApiInfo.RemainCount;
                __reset_time = eargs.ApiInfo.ResettTime;
                __reset_in_seconds = eargs.ApiInfo.ResetInSeconds;
            }
        }
        
        
//        private int max_count_;
//        private int remain_count_;
//        private DateTime reset_time_;
//        private int reset_time_in_seconds_;
//        private int using_count_;
//        private ApiAccessLevel access_level_;
//        private int media_max_count_;
//        private DateTime media_reset_time_;
//        private int media_remain_count_;
    }


}
