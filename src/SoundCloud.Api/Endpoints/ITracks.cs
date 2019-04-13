using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SoundCloud.Api.Entities;
using SoundCloud.Api.Exceptions;
using SoundCloud.Api.QueryBuilders;

namespace SoundCloud.Api.Endpoints
{
    public interface ITracks
    {
        /// <summary>
        ///     Deletes the given track
        /// </summary>
        /// <param name="track">Track to delete</param>
        Task<StatusResponse> DeleteAsync(Track track);

        /// <summary>
        ///     Gets a track
        /// </summary>
        Task<Track> GetAsync(int trackId);

        /// <summary>
        ///     Gets a list of tracks
        /// </summary>
        Task<IEnumerable<Track>> GetAllAsync(int limit = SoundCloudQueryBuilder.MaxLimit, int offset = 0);

        /// <summary>
        ///     Gets a list of tracks
        /// </summary>
        Task<IEnumerable<Track>> GetAllAsync(TrackQueryBuilder builder);

        /// <summary>
        ///     Gets comments for the track
        /// </summary>
        Task<IEnumerable<Comment>> GetCommentsAsync(Track track, int limit = SoundCloudQueryBuilder.MaxLimit, int offset = 0);

        /// <summary>
        ///     Gets users who favorited the track
        /// </summary>
        Task<IEnumerable<User>> GetFavoritersAsync(Track track, int limit = SoundCloudQueryBuilder.MaxLimit, int offset = 0);

        /// <summary>
        ///     Gets the secret token of the track
        /// </summary>
        Task<SecretToken> GetSecretTokenAsync(Track track);

        /// <summary>
        ///     Updates a track
        /// </summary>
        /// <exception cref="SoundCloudValidationException">Thrown if validation of <paramref name="track" /> failed.</exception>
        Task<Track> UpdateAsync(Track track);

        /// <summary>
        ///     Uploads a Artwork
        /// </summary>
        /// <exception cref="SoundCloudValidationException">Thrown if validation of <paramref name="track" /> failed.</exception>
        Task<Track> UploadArtworkAsync(Track track, Stream file);

        /// <summary>
        ///     Uploads a track
        /// </summary>
        /// <exception cref="SoundCloudValidationException">Thrown if validation of <paramref name="title" /> failed.</exception>
        Task<Track> UploadTrackAsync(string title, Stream file);
    }
}