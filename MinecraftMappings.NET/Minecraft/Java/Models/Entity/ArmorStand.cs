using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class ArmorStand : JavaEntityModel
    {
        public ArmorStand() : base("Armor Stand")
        {
            AddVersion("armor_stand", "1.0")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, -23f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 23f, -1f),
                        Size = new Vector3(2f, 7f, 2f),
                    });
                })
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 21f, -1.5f),
                        Size = new Vector3(12f, 3f, 3f),
                        UV = new Vector2(0f, 26f),
                    });
                })
                .AddElement("left_arm", element => {
                    element.Translate = new Vector3(5f, -22f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-7f, 12f, -1f),
                        Size = new Vector3(2f, 12f, 2f),
                        UV = new Vector2(32f, 16f),
                    });
                })
                .AddElement("right_arm", element => {
                    element.Translate = new Vector3(-5f, -22f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(5f, 12f, -1f),
                        Size = new Vector3(2f, 12f, 2f),
                        UV = new Vector2(24f, 0f),
                    });
                })
                .AddElement("left_leg", element => {
                    element.Translate = new Vector3(1.85f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                    element.MirrorTexU = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2.9f, 1f, -1f),
                        Size = new Vector3(2f, 11f, 2f),
                        UV = new Vector2(40f, 16f),
                    });
                })
                .AddElement("right_leg", element => {
                    element.Translate = new Vector3(-1.85f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1.05f, 1f, -1f),
                        Size = new Vector3(2f, 11f, 2f),
                        UV = new Vector2(8f, 0f),
                    });
                })
                .AddElement("right", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 14f, -1f),
                        Size = new Vector3(2f, 7f, 2f),
                        UV = new Vector2(48f, 16f),
                    });
                })
                .AddElement("left", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 14f, -1f),
                        Size = new Vector3(2f, 7f, 2f),
                        UV = new Vector2(16f, 0f),
                    });
                })
                .AddElement("waist", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 12f, -1f),
                        Size = new Vector3(8f, 2f, 2f),
                        UV = new Vector2(0f, 48f),
                    });
                })
                .AddElement("base", element => {
                    element.Translate = new Vector3(0f, -12f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 0f, -6f),
                        Size = new Vector3(12f, 1f, 12f),
                        UV = new Vector2(0f, 32f),
                    });
                });
        }
    }
}
