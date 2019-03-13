﻿using System;
using System.IO;

using Newtonsoft.Json;

using NUnit.Framework;

namespace SoundCloud.Api.IntegrationTest
{
    /// <summary>
    /// This class tests the logic of the wrapper against the real SoundCloud API.
    /// Therefore a clientid and token is needed. Both values are loaded from a settings.json file.
    /// In order to run this tests, the file must be provided.
    /// All tests are marked as inconclusive, if the file is not available.
    /// </summary>
    [TestFixture]
    public partial class SoundCloudClientTest
    {
        // Taken from https://soundcloud.com/sharpsound-2
        private const int CommentId = 240653022;
        private const int GroupId = 216171;
        private const int PlaylistId = 131472367;
        private const string SettingsFile = "settings.json";
        private const string SharpSoundGroupName = "SharpSoundGroup";
        private const int Track2Id = 219360956;
        private const int Track3Id = 234707391;
        private const int TrackId = 219359541;
        private const int UserId = 164386753;
        private Settings _settings;

        [SetUp]
        public void Setup()
        {
            if (_settings == null)
            {
                Assert.Inconclusive("No settings loaded. ClientId and AccessToken not available");
            }
        }

        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            // Resharper Fix, wrong working directory
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SettingsFile);

            if (!File.Exists(path))
            {
                Assert.Inconclusive("No settings loaded. ClientId and AccessToken not available");
            }

            using (var reader = new StreamReader(File.Open(path, FileMode.Open)))
            {
                _settings = JsonConvert.DeserializeObject<Settings>(reader.ReadToEnd());
            }
        }
    }

    internal class Settings
    {
        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }

        public string Username { get; set; }
    }
}