﻿using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaDoorTop : JavaBlockModel
    {
        public AcaciaDoorTop() : base("Acacia Door, Top")
        {
            AddVersion("acacia_door_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top")
                .AddTexture("top", "block/acacia_door_top")
                .AddTexture("bottom", "block/acacia_door_bottom");
        }
    }
}
