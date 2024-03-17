using MinecraftMappings.Internal.Items;
using MinecraftMappings.Internal.Models.Block;
using MinecraftMappings.Internal.Models.Entity;
using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Internal.Textures.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MinecraftMappings.Internal.Extensions;

namespace MinecraftMappings.Internal
{
    public class MinecraftGameEdition
    {
        // TODO: move to instance class so bedrock works!
        protected static readonly Regex EntityPathExp = new(@"(?:^|[\\/])textures[\\/]entity[\\/]([\w/]+)[\\/]\w+$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    }

    public abstract class MinecraftGameEdition<TBlockTexture, TBlockModel, TEntityTexture, TEntityModel, TItem> : MinecraftGameEdition
        where TBlockTexture : IBlockTexture
        where TBlockModel : IBlockModel
        where TEntityTexture : IEntityTexture
        where TEntityModel : IEntityModel
        where TItem : IItemData
    {
        private static readonly Lazy<IEnumerable<TBlockTexture>> allBlockTexturesLazy = new(BlockTexture.FromAssembly<TBlockTexture>);
        private static readonly Lazy<IEnumerable<TBlockModel>> allBlockModelsLazy = new(BlockModel.FromAssembly<TBlockModel>);
        private static readonly Lazy<IEnumerable<TEntityTexture>> allEntityTexturesLazy = new(EntityTexture.FromAssembly<TEntityTexture>);
        private static readonly Lazy<IEnumerable<TEntityModel>> allEntityModelsLazy = new(EntityModel.FromAssembly<TEntityModel>);
        private static readonly Lazy<IEnumerable<TItem>> allItemsLazy = new(ItemData.FromAssembly<TItem>);

        public IEnumerable<TBlockTexture> AllBlockTextures => allBlockTexturesLazy.Value;
        public IEnumerable<TBlockModel> AllBlockModels => allBlockModelsLazy.Value;
        public IEnumerable<TEntityTexture> AllEntityTextures => allEntityTexturesLazy.Value;
        public IEnumerable<TEntityModel> AllEntityModels => allEntityModelsLazy.Value;
        public IEnumerable<TItem> AllItems => allItemsLazy.Value;



        public IEnumerable<TBlock> FindBlockTexturesById<TBlock, TBlockVersion>(string id, string? path = null)
            where TBlock : IBlockTexture<TBlockVersion>
            where TBlockVersion : BlockTextureVersion
        {
            // TODO: add path preference sorting

            return allBlockTexturesLazy.Value.OfType<TBlock>()
                .Where(block => block.Versions.Any(v => string.Equals(v.Id, id, StringComparison.InvariantCultureIgnoreCase)));
        }

        public IEnumerable<TEntity> FindEntityTexturesById<TEntity, TEntityVersion>(string id)
            where TEntity : IEntityTexture<TEntityVersion>
            where TEntityVersion : EntityTextureVersion
        {
            return allEntityTexturesLazy.Value.OfType<TEntity>()
                .Where(entity => entity.Versions.Any(v => string.Equals(v.Id, id, StringComparison.InvariantCultureIgnoreCase)));
        }

        public IEnumerable<TBlockVersion> FindBlockTextureVersionById<TBlockVersion>(string id)
            where TBlockVersion : BlockTextureVersion, new()
        {
            return allBlockTexturesLazy.Value
                .OfType<IBlockTexture<TBlockVersion>>()
                .SelectMany(block => block.Versions)
                .Where(latest => string.Equals(latest.Id, id, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<TEntityVersion> FindLatestEntityTextureVersionById<TEntityVersion>(string id, string? path = null)
            where TEntityVersion : EntityTextureVersion, new()
        {
            var searchPath = $"{path}/{id}";

            return allEntityTexturesLazy.Value
                .OfType<IEntityTexture<TEntityVersion>>()
                .Select(entity => entity.GetLatestVersion())
                .WhereNotNull(latest => string.Equals(latest.Id, id, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(t => {
                    // TODO: regex to get entity/* path?
                    var pathMatch = EntityPathExp.Match(searchPath);
                    if (pathMatch.Success && pathMatch.Groups.Count == 2) {
                        var entityPath = pathMatch.Groups[1].Value;
                        if (string.Equals(t.Path, $"entity/{entityPath}", StringComparison.InvariantCultureIgnoreCase)) return 2;
                    }

                    return MatchesPath($@"assets/*/textures/{t.Path}", path) ? 1 : 0;
                });
        }

        private static bool MatchesPath(string expectedExp, string? actualPath)
        {
            // TODO: find "textures/entity/* 
            return true;
        }

        public IEnumerable<TItemVersion> FindItemVersionById<TItemVersion>(string id)
            where TItemVersion : ItemDataVersion, new()
        {
            return allItemsLazy.Value
                .OfType<IItemData<TItemVersion>>().Select(item => item.GetLatestVersion())
                .WhereNotNull(latest => string.Equals(latest.Id, id, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<TEntityTextureVersion> FindEntityTextureVersionById<TEntityTextureVersion>(string id)
            where TEntityTextureVersion : EntityTextureVersion, new()
        {
            return allEntityTexturesLazy.Value
                .OfType<IEntityTexture<TEntityTextureVersion>>().Select(entity => entity.GetLatestVersion())
                .WhereNotNull(latest => string.Equals(id, latest.Id, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<TEntityVersion> FindEntityModelVersionById<TEntityVersion>(string id)
            where TEntityVersion : EntityModelVersion, new()
        {
            return allEntityModelsLazy.Value.OfType<IEntityModel<TEntityVersion>>()
                .Select(entity => entity.GetLatestVersion())
                .WhereNotNull(latest => string.Equals(latest.Id, id, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<TEntityVersion> GetEntitiesByVersion<TEntityVersion>(Version version)
            where TEntityVersion : EntityModelVersion, new()
        {
            return allEntityModelsLazy.Value.OfType<IEntityModel<TEntityVersion>>()
                .Select(entity => entity.GetVersion(version)).WhereNotNull();
        }

        public IEnumerable<BlockModelVersion> FindBlockModelVersionById(string id)
        {
            return allBlockModelsLazy.Value
                .OfType<IBlockModel>().Select(model => model.GetLatestVersion())
                .WhereNotNull(latest => string.Equals(latest.Id, id, StringComparison.OrdinalIgnoreCase));
        }

        public TBlockModel? GetBlockModelForTexture<TBlockTextureVersion>(string? textureId)
            where TBlockTextureVersion : BlockTextureVersion, new()
        {
            if (textureId == null) return default;

            var blockTextures = FindBlockTextureVersionById<TBlockTextureVersion>(textureId);
            var modelType = blockTextures.FirstOrDefault()?.DefaultModel;
            if (modelType == null) return default;

            return (TBlockModel?)Activator.CreateInstance(modelType);
        }

        public TEntityModel? GetEntityModelForTexture<TEntityVersion>(string? textureId, string? path = null)
            where TEntityVersion : EntityTextureVersion, new()
        {
            if (textureId == null) return default;

            var entityTextures = FindLatestEntityTextureVersionById<TEntityVersion>(textureId, path);
            var modelType = entityTextures.FirstOrDefault()?.DefaultModel;
            if (modelType == null) return default;

            return (TEntityModel?)Activator.CreateInstance(modelType);
        }
    }
}
