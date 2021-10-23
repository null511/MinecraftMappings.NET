using MinecraftMappings.Internal.Items;
using MinecraftMappings.Internal.Models.Block;
using MinecraftMappings.Internal.Models.Entity;
using MinecraftMappings.Internal.Textures.Block;
using System;
using System.Collections.Generic;
using System.Linq;
using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Internal
{
    public abstract class MinecraftGameEdition<TBlockTexture, TBlockModel, TEntityTexture, TEntityModel, TItem>
        where TBlockTexture : IBlockTexture
        where TBlockModel : IBlockModel
        where TEntityTexture : IEntityTexture
        where TEntityModel : IEntityModel
        where TItem : IItemData
    {
        private static readonly Lazy<IEnumerable<TBlockTexture>> allBlockTexturesLazy = new Lazy<IEnumerable<TBlockTexture>>(BlockTexture.FromAssembly<TBlockTexture>);
        private static readonly Lazy<IEnumerable<TBlockModel>> allBlockModelsLazy = new Lazy<IEnumerable<TBlockModel>>(BlockModel.FromAssembly<TBlockModel>);
        private static readonly Lazy<IEnumerable<TEntityTexture>> allEntityTexturesLazy = new Lazy<IEnumerable<TEntityTexture>>(EntityTexture.FromAssembly<TEntityTexture>);
        private static readonly Lazy<IEnumerable<TEntityModel>> allEntityModelsLazy = new Lazy<IEnumerable<TEntityModel>>(EntityModel.FromAssembly<TEntityModel>);
        private static readonly Lazy<IEnumerable<TItem>> allItemsLazy = new Lazy<IEnumerable<TItem>>(ItemData.FromAssembly<TItem>);

        public IEnumerable<TBlockTexture> AllBlockTextures => allBlockTexturesLazy.Value;
        public IEnumerable<TBlockModel> AllBlockModels => allBlockModelsLazy.Value;
        public IEnumerable<TEntityTexture> AllEntityTextures => allEntityTexturesLazy.Value;
        public IEnumerable<TEntityModel> AllEntityModels => allEntityModelsLazy.Value;
        public IEnumerable<TItem> AllItems => allItemsLazy.Value;


        public IEnumerable<TBlockVersion> FindLatestBlockTextureVersionById<TBlockVersion>(string id)
            where TBlockVersion : BlockTextureVersion, new()
        {
            return allBlockTexturesLazy.Value.OfType<IBlockTexture<TBlockVersion>>()
                .Select(block => block.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TEntityVersion> FindLatestEntityTextureVersionById<TEntityVersion>(string id)
            where TEntityVersion : EntityTextureVersion, new()
        {
            return allEntityTexturesLazy.Value.OfType<IEntityTexture<TEntityVersion>>()
                .Select(entity => entity.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TItemVersion> FindItemVersionById<TItemVersion>(string id)
            where TItemVersion : ItemDataVersion, new()
        {
            return allItemsLazy.Value.OfType<IItemData<TItemVersion>>()
                .Select(item => item.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TEntityTextureVersion> FindEntityTextureVersionById<TEntityTextureVersion>(string id)
            where TEntityTextureVersion : EntityTextureVersion, new()
        {
            return allEntityTexturesLazy.Value.OfType<IEntityTexture<TEntityTextureVersion>>()
                .Select(entity => entity.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TEntityVersion> FindEntityModelVersionById<TEntityVersion>(string id)
            where TEntityVersion : EntityModelVersion, new()
        {
            return allEntityModelsLazy.Value.OfType<IEntityModel<TEntityVersion>>()
                .Select(entity => entity.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TEntityVersion> GetEntitiesByVersion<TEntityVersion>(Version version)
            where TEntityVersion : EntityModelVersion, new()
        {
            return allEntityModelsLazy.Value.OfType<IEntityModel<TEntityVersion>>()
                .Select(entity => entity.GetVersion(version));
        }

        public IEnumerable<BlockModelVersion> FindBlockModelVersionById(string id)
        {
            return allBlockModelsLazy.Value.OfType<IBlockModel>()
                .Select(model => model.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public TBlockModel GetBlockModelForTexture<TBlockTextureVersion>(string textureId)
            where TBlockTextureVersion : BlockTextureVersion, new()
        {
            if (textureId == null) return default;

            var blockTextures = FindLatestBlockTextureVersionById<TBlockTextureVersion>(textureId);
            var modelType = blockTextures.FirstOrDefault()?.DefaultModel;
            if (modelType == null) return default;

            return (TBlockModel)Activator.CreateInstance(modelType);
        }

        public TEntityModel GetEntityModelForTexture<TEntityVersion>(string textureId)
            where TEntityVersion : EntityTextureVersion, new()
        {
            if (textureId == null) return default;

            var entityTextures = FindLatestEntityTextureVersionById<TEntityVersion>(textureId);
            var modelType = entityTextures.FirstOrDefault()?.DefaultModel;
            if (modelType == null) return default;

            return (TEntityModel)Activator.CreateInstance(modelType);
        }
    }
}
