﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class Person
    {
        public string Name;
        private List<Person> friends;
        private List<Playlist> playlists;

        public List<Playlist> Playlists { get => playlists; set => playlists = value; }
        public List<Person> Friends { get => friends; set => friends = value; }

        public Person(string name)
        {
            Name = name;
        }

        public List<Person> ShowFriends()
        {
            return Friends;
        }

        public List<Playlist> ShowPlaylists()
        {
        }

        public Playlist SelectPlaylist(int id)
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
