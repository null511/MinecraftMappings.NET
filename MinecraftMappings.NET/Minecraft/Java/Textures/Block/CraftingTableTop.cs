﻿using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CraftingTableTop : JavaBlockTexture
    {
        public CraftingTableTop() : base("Crafting Table, Top")
        {
            AddVersion("crafting_table_top")
                .WithDefaultModel<Java.Models.Block.CraftingTable>();
                //.MapsToBedrockBlock<BedrockBlocks.CraftingTableSide>();
        }
    }
}