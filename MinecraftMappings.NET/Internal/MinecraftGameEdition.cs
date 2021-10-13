using MinecraftMappings.Internal.Items;
using MinecraftMappings.Internal.Models.Block;
using MinecraftMappings.Internal.Models.Entity;
using MinecraftMappings.Internal.Textures.Block;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MinecraftMappings.Internal
{
    public abstract class MinecraftGameEdition<TBlockTexture, TItem, TEntity, TModel>
        where TBlockTexture : IBlockTexture
        where TItem : IItemData
        where TEntity : IEntityModel
        where TModel : IBlockModel
    {
        private static readonly Lazy<IEnumerable<TBlockTexture>> allBlocksLazy = new Lazy<IEnumerable<TBlockTexture>>(BlockTexture.FromAssembly<TBlockTexture>);
        private static readonly Lazy<IEnumerable<TItem>> allItemsLazy = new Lazy<IEnumerable<TItem>>(ItemData.FromAssembly<TItem>);
        private static readonly Lazy<IEnumerable<TEntity>> allEntitiesLazy = new Lazy<IEnumerable<TEntity>>(EntityModel.FromAssembly<TEntity>);
        private static readonly Lazy<IEnumerable<TModel>> allModelsLazy = new Lazy<IEnumerable<TModel>>(BlockModel.FromAssembly<TModel>);

        public IEnumerable<TBlockTexture> AllBlocks => allBlocksLazy.Value;
        public IEnumerable<TItem> AllItems => allItemsLazy.Value;
        public IEnumerable<TEntity> AllEntities => allEntitiesLazy.Value;
        public IEnumerable<TModel> AllModels => allModelsLazy.Value;


        public IEnumerable<TBlockVersion> FindLatestBlockTextureVersionById<TBlockVersion>(string id)
            where TBlockVersion : BlockTextureVersion, new()
        {
            return allBlocksLazy.Value.OfType<IBlockTexture<TBlockVersion>>()
                .Select(block => block.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TItemVersion> FindItemVersionById<TItemVersion>(string id)
            where TItemVersion : ItemDataVersion, new()
        {
            return allItemsLazy.Value.OfType<IItemData<TItemVersion>>()
                .Select(item => item.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TEntityVersion> FindEntityVersionById<TEntityVersion>(string id)
            where TEntityVersion : EntityModelVersion, new()
        {
            return allEntitiesLazy.Value.OfType<IEntityModel<TEntityVersion>>()
                .Select(entity => entity.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IEnumerable<TEntityVersion> GetEntitiesByVersion<TEntityVersion>(Version version)
            where TEntityVersion : EntityModelVersion, new()
        {
            return allEntitiesLazy.Value.OfType<IEntityModel<TEntityVersion>>()
                .Select(entity => entity.GetVersion(version));
        }

        public IEnumerable<BlockModelVersion> FindModelVersionById(string id)
        {
            return allModelsLazy.Value
                .Select(model => model.GetLatestVersion())
                .Where(latest => latest.Id.Equals(id));
        }

        public IBlockModel GetModelForTexture<TBlockVersion>(string textureId)
            where TBlockVersion : BlockTextureVersion, new()
        {
            if (textureId == null) return null;

            var blockTextures = FindLatestBlockTextureVersionById<TBlockVersion>(textureId);
            var modelType = blockTextures.FirstOrDefault()?.DefaultModel;
            if (modelType == null) return null;

            return (IBlockModel)Activator.CreateInstance(modelType);
        }
    }
}
