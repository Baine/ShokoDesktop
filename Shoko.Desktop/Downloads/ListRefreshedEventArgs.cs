﻿using System;
using System.Collections.Generic;

namespace Shoko.Desktop.Downloads
{
    public class ListRefreshedEventArgs : EventArgs
    {
        public readonly List<Torrent> Torrents = new List<Torrent>();

        public ListRefreshedEventArgs(List<Torrent> tors)
        {
            Torrents = tors;
        }
    }
}