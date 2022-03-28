using System;
using System.Collections.Generic;

namespace MinecraftMappings.Minecraft.LegacyJavaToBedrockMappings
{
    public class LegacyOtherMappings : Dictionary<string, string>
    {
        public static LegacyOtherMappings Instance {get;} = new();

        private LegacyOtherMappings() : base(new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {
            ["assets/minecraft/textures/colormap/grass"] = "textures/colormap/grass",
            ["assets/minecraft/textures/colormap/foliage"] = "textures/colormap/foliage",
            ["assets/minecraft/textures/colormap/swamp_grass"] = "textures/colormap/swamp_grass",
            ["assets/minecraft/textures/colormap/swamp_foliage"] = "textures/colormap/swamp_foliage",

            ["assets/minecraft/textures/environment/clouds"] = "textures/environment/clouds",
            ["assets/minecraft/textures/environment/end_sky"] = "textures/environment/end_sky",
            ["assets/minecraft/textures/environment/moon_phases"] = "textures/environment/moon_phases",
            ["assets/minecraft/textures/environment/sun"] = "textures/environment/sun",

            //["assets/minecraft/textures/block/destroy_stage_0"] = "textures/environment/destroy_stage_0",
            //["assets/minecraft/textures/block/destroy_stage_1"] = "textures/environment/destroy_stage_1",
            //["assets/minecraft/textures/block/destroy_stage_2"] = "textures/environment/destroy_stage_2",
            //["assets/minecraft/textures/block/destroy_stage_3"] = "textures/environment/destroy_stage_3",
            //["assets/minecraft/textures/block/destroy_stage_4"] = "textures/environment/destroy_stage_4",
            //["assets/minecraft/textures/block/destroy_stage_5"] = "textures/environment/destroy_stage_5",
            //["assets/minecraft/textures/block/destroy_stage_6"] = "textures/environment/destroy_stage_6",
            //["assets/minecraft/textures/block/destroy_stage_7"] = "textures/environment/destroy_stage_7",
            //["assets/minecraft/textures/block/destroy_stage_8"] = "textures/environment/destroy_stage_8",
            //["assets/minecraft/textures/block/destroy_stage_9"] = "textures/environment/destroy_stage_9",
        }) {}
    }
}
