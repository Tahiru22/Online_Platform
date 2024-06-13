namespace Online_Platform.Infrastructure.Configurations
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.Caching.Memory;
    using Online_Platform.Infrastructure.Constant;
    using Online_Platform.Services.Admin.Models.Curriculums;
    using Online_Platform.Services.Admin.Models.Users;

    public static class MemoryCacheExtensions
    {
        public static void Clear(this IMemoryCache cache, int curriculumId)
        {
            cache.Remove(GetCandidatesKey(curriculumId));
            cache.Remove(GetGraduatesKey(curriculumId));
        }

        public static IEnumerable<AdminUserListingServiceModel> GetCandidates(this IMemoryCache cache, int curriculumId)
        {
            var cacheKey = GetCandidatesKey(curriculumId);
            return cache.Get(cacheKey) as IEnumerable<AdminUserListingServiceModel>;
        }

        public static IEnumerable<AdminDiplomaGraduateServiceModel> GetGraduates(this IMemoryCache cache, int curriculumId)
        {
            var cacheKey = GetGraduatesKey(curriculumId);
            return cache.Get(cacheKey) as IEnumerable<AdminDiplomaGraduateServiceModel>;
        }

        public static void SetCandidates(this IMemoryCache cache, int curriculumId, object value)
        {
            var cacheKey = GetCandidatesKey(curriculumId);
            cache.Set(cacheKey, value, DateTimeOffset.UtcNow.AddMinutes(WebConstants.CacheExpirationInMinutes));
        }

        public static void SetGraduates(this IMemoryCache cache, int curriculumId, object value)
        {
            var cacheKey = GetGraduatesKey(curriculumId);
            cache.Set(cacheKey, value, DateTimeOffset.UtcNow.AddMinutes(WebConstants.CacheExpirationInMinutes));
        }

        private static string GetCandidatesKey(int curriculumId)
            => WebConstants.CacheCandidatesKey + curriculumId;

        private static string GetGraduatesKey(int curriculumId)
            => WebConstants.CacheGraduatesKey + curriculumId;
    }
}
