using System;
using System.Collections.Generic;

namespace MinecraftMappings.Minecraft.LegacyJavaToBedrockMappings
{
    public class LegacyItemMappings : Dictionary<string, string>
    {
        public static LegacyItemMappings Instance {get;} = new();

        private LegacyItemMappings() : base(new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase) {
            ["assets/minecraft/textures/item/acacia_boat"] = "textures/items/boat_acacia",
            ["assets/minecraft/textures/item/acacia_door"] = "textures/items/door_acacia",
            ["assets/minecraft/textures/item/acacia_sign"] = "textures/items/sign_acacia",
            //["assets/minecraft/textures/item/amethyst_shard"] = "textures/items/",
            ["assets/minecraft/textures/item/apple"] = "textures/items/apple",
            ["assets/minecraft/textures/item/armor_stand"] = "textures/items/armor_stand",
            ["assets/minecraft/textures/item/arrow"] = "textures/items/arrow",
            ["assets/minecraft/textures/item/baked_potato"] = "textures/items/potato_baked",
            ["assets/minecraft/textures/item/bamboo"] = "textures/items/bamboo",
            ["assets/minecraft/textures/item/beef"] = "textures/items/beef_raw",
            ["assets/minecraft/textures/item/beetroot"] = "textures/items/beetroot",
            ["assets/minecraft/textures/item/beetroot_seeds"] = "textures/items/seeds_beetroot",
            ["assets/minecraft/textures/item/beetroot_soup"] = "textures/items/beetroot_soup",
            //["assets/minecraft/textures/item/bell"] = "textures/items/",
            ["assets/minecraft/textures/item/birch_boat"] = "textures/items/boat_birch",
            ["assets/minecraft/textures/item/birch_door"] = "textures/items/door_birch",
            ["assets/minecraft/textures/item/birch_sign"] = "textures/items/sign_birch",
            ["assets/minecraft/textures/item/black_dye"] = "textures/items/dye_powder_black_new",
            ["assets/minecraft/textures/item/blaze_powder"] = "textures/items/blaze_powder",
            ["assets/minecraft/textures/item/blaze_rod"] = "textures/items/blaze_rod",
            ["assets/minecraft/textures/item/blue_dye"] = "textures/items/dye_powder_blue_new",
            ["assets/minecraft/textures/item/bone"] = "textures/items/bone",
            ["assets/minecraft/textures/item/bone_meal"] = "textures/items/dye_powder_white",
            ["assets/minecraft/textures/item/book"] = "textures/items/book_normal",
            ["assets/minecraft/textures/item/bow"] = "textures/items/bow_standby",
            ["assets/minecraft/textures/item/bow_pulling_0"] = "textures/items/bow_pulling_0",
            ["assets/minecraft/textures/item/bow_pulling_1"] = "textures/items/bow_pulling_1",
            ["assets/minecraft/textures/item/bow_pulling_2"] = "textures/items/bow_pulling_2",
            ["assets/minecraft/textures/item/bowl"] = "textures/items/bowl",
            ["assets/minecraft/textures/item/bread"] = "textures/items/bread",
            ["assets/minecraft/textures/item/brewing_stand"] = "textures/items/brewing_stand",
            ["assets/minecraft/textures/item/brick"] = "textures/items/brick",
            ["assets/minecraft/textures/item/broken_elytra"] = "textures/items/broken_elytra",
            ["assets/minecraft/textures/item/brown_dye"] = "textures/items/dye_powder_brown_new",
            ["assets/minecraft/textures/item/bucket"] = "textures/items/bucket_empty",
            ["assets/minecraft/textures/item/cake"] = "textures/items/cake",

            //["assets/minecraft/textures/item/"] = "textures/items/",
        }) {}
    }
}
