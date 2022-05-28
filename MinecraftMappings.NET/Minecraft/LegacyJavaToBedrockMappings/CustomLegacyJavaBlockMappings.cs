using System;
using System.Collections.Generic;

namespace MinecraftMappings.Minecraft.LegacyJavaToBedrockMappings
{
    public class CustomLegacyJavaBlockMappings : Dictionary<string, string>
    {
        public static CustomLegacyJavaBlockMappings Instance {get;} = new();

        private CustomLegacyJavaBlockMappings() : base(new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {
            // 1.17.1 grass -> dirt path fix
            ["assets/minecraft/textures/block/dirt_path_side"] = "textures/blocks/grass_path_side",
            ["assets/minecraft/textures/block/dirt_path_top"] = "textures/blocks/grass_path_top",

            // CUSTOM MAPPING
            ["assets/minecraft/textures/block/terracotta/default"] = "textures/blocks/hardened_clay",
            ["assets/minecraft/textures/block/terracotta/black"] = "textures/blocks/hardened_clay_stained_black",
            ["assets/minecraft/textures/block/terracotta/blue"] = "textures/blocks/hardened_clay_stained_blue",
            ["assets/minecraft/textures/block/terracotta/brown"] = "textures/blocks/hardened_clay_stained_brown",
            ["assets/minecraft/textures/block/terracotta/cyan"] = "textures/blocks/hardened_clay_stained_cyan",
            ["assets/minecraft/textures/block/terracotta/gray"] = "textures/blocks/hardened_clay_stained_gray",
            ["assets/minecraft/textures/block/terracotta/green"] = "textures/blocks/hardened_clay_stained_green",
            ["assets/minecraft/textures/block/terracotta/light_blue"] = "textures/blocks/hardened_clay_stained_light_blue",
            ["assets/minecraft/textures/block/terracotta/lime"] = "textures/blocks/hardened_clay_stained_lime",
            ["assets/minecraft/textures/block/terracotta/magenta"] = "textures/blocks/hardened_clay_stained_magenta",
            ["assets/minecraft/textures/block/terracotta/orange"] = "textures/blocks/hardened_clay_stained_orange",
            ["assets/minecraft/textures/block/terracotta/pink"] = "textures/blocks/hardened_clay_stained_pink",
            ["assets/minecraft/textures/block/terracotta/purple"] = "textures/blocks/hardened_clay_stained_purple",
            ["assets/minecraft/textures/block/terracotta/red"] = "textures/blocks/hardened_clay_stained_red",
            ["assets/minecraft/textures/block/terracotta/light_gray"] = "textures/blocks/hardened_clay_stained_silver",
            ["assets/minecraft/textures/block/terracotta/white"] = "textures/blocks/hardened_clay_stained_white",
            ["assets/minecraft/textures/block/terracotta/yellow"] = "textures/blocks/hardened_clay_stained_yellow",

            ["assets/minecraft/textures/block/wool/black"] = "textures/blocks/wool_colored_black",
            ["assets/minecraft/textures/block/wool/blue"] = "textures/blocks/wool_colored_blue",
            ["assets/minecraft/textures/block/wool/brown"] = "textures/blocks/wool_colored_brown",
            ["assets/minecraft/textures/block/wool/cyan"] = "textures/blocks/wool_colored_cyan",
            ["assets/minecraft/textures/block/wool/gray"] = "textures/blocks/wool_colored_gray",
            ["assets/minecraft/textures/block/wool/green"] = "textures/blocks/wool_colored_green",
            ["assets/minecraft/textures/block/wool/light_blue"] = "textures/blocks/wool_colored_light_blue",
            ["assets/minecraft/textures/block/wool/lime"] = "textures/blocks/wool_colored_lime",
            ["assets/minecraft/textures/block/wool/magenta"] = "textures/blocks/wool_colored_magenta",
            ["assets/minecraft/textures/block/wool/orange"] = "textures/blocks/wool_colored_orange",
            ["assets/minecraft/textures/block/wool/pink"] = "textures/blocks/wool_colored_pink",
            ["assets/minecraft/textures/block/wool/purple"] = "textures/blocks/wool_colored_purple",
            ["assets/minecraft/textures/block/wool/red"] = "textures/blocks/wool_colored_red",
            ["assets/minecraft/textures/block/wool/light_gray"] = "textures/blocks/wool_colored_silver",
            ["assets/minecraft/textures/block/wool/white"] = "textures/blocks/wool_colored_white",
            ["assets/minecraft/textures/block/wool/yellow"] = "textures/blocks/wool_colored_yellow",
        }) {}
    }
}
