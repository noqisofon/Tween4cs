//  
//  SpaceKeyCanceler.cs
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
using System.Windows.Forms;


namespace Tween.Widgets {


    /**
     * 
     */
    internal class SpaceKeyCanceler : NativeWindow, IDisposable {
        /**
         * 
         */
        public SpaceKeyCanceler(Control control) {
            base.AssignHandle( control.Handle );
        }


        /**
         * 
         */
        protected override void WndProc(ref Message m) {
            if ( m.Msg == WM_KEYDOWN && (int)m.WParam == VK_SPACE ) {
                this.PerformSpaceCansel( EventArgs.Empty );

                return ;
            }
            base.WndProc( ref m );
        }


        /**
         * 
         */
        protected void PerformSpaceCansel(EventArgs ergs) {
            if ( SpaceCancel != null )
                SpaceCancel( this, ergs );
        }


        /**
         * 
         */
        void IDisposable.Dispose() {
            this.RelaseHandle();
        }


        public event EventHandler SpaceCancel;


        private const int WM_KEYDOWN = 0x100;
        private const int VK_SPACE = 0x20;
    }


}
