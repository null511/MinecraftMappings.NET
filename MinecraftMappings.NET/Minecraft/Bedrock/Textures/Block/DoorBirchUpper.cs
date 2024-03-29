﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class DoorBirchUpper : BedrockBlockTexture
    {
        public DoorBirchUpper() : base("Door Birch Upper")
        {
            AddVersion("door_birch_upper")
                .MapsToJavaBlock<Java.Textures.Block.BirchDoorTop>();
        }
    }
}
