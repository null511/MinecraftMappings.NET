using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class ArmorLayer1 : JavaEntityModel
    {
        public ArmorLayer1() : base("Armor, Layer 1")
        {
            AddVersion("armor_layer_1", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 23f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = Vector2.Zero,
                        SizeAdd = 0.75f,
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 23f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = new Vector2(32f, 0f),
                        SizeAdd = 1.0f,
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 12f, -2f),
                        Size = new Vector3(8f, 12f, 4f),
                        UV = new Vector2(16f, 16f),
                        SizeAdd = 0.75f,
                    });
                })
                .AddElement("left_shoe", element => {
                    element.Part = "left_shoe";
                    element.Translate = new Vector3(-2f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 16f),
                        SizeAdd = 0.75f,
                    });
                })
                .AddElement("right_shoe", element => {
                    element.Part = "right_shoe";
                    element.Translate = new Vector3(2f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 16f),
                        SizeAdd = 0.75f,
                    });
                })
                .AddElement("left_arm", element => {
                    element.Part = "left_arm";
                    element.Translate = new Vector3(-5f, -22f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 12f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(40f, 16f),
                        SizeAdd = 0.75f,
                    });
                })
                .AddElement("right_arm", element => {
                    element.Part = "right_arm";
                    element.Translate = new Vector3(5f, -22f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 12f, -2f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(40f, 16f),
                        SizeAdd = 0.75f,
                    });
                });
        }
    }
}
