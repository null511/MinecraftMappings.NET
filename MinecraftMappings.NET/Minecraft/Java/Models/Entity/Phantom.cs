using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Phantom : JavaEntityModel
    {
        public Phantom() : base("Phantom")
        {
            AddVersion("phantom", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("body", element => {
                    element.Translate = new Vector3(0.5f, -5f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 4f, -8f),
                        Size = new Vector3(5f, 3f, 9f),
                        UV = new Vector2(0f, 8f),
                    });
                })
                .AddElement("head", element => {
                    element.Translate = new Vector3(0.5f, -3.75f, 8f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 2.75f, -13f),
                        Size = new Vector3(7f, 3f, 5f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("left_wing", element => {
                    element.Translate = new Vector3(2.5f, -7f, 8f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-8.5f, 5f, -8f),
                        Size = new Vector3(6f, 2f, 9f),
                        UV = new Vector2(23f, 12f),
                    });
                })
                .AddElement("left_wing_tip", element => {
                    element.Translate = new Vector3(8.5f, -7f, 8f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-21.5f, 6f, -8f),
                        Size = new Vector3(13f, 1f, 9f),
                        UV = new Vector2(16f, 24f),
                    });
                })
                .AddElement("right_wing", element => {
                    element.Translate = new Vector3(-2.5f, -7f, 8f);
                    element.MirrorTexU = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(2.5f, 5f, -8f),
                        Size = new Vector3(6f, 2f, 9f),
                        UV = new Vector2(23f, 12f),
                    });
                })
                .AddElement("right_wing_tip", element => {
                    element.Translate = new Vector3(-8.5f, -7f, 8f);
                    element.MirrorTexU = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(8.5f, 6f, -8f),
                        Size = new Vector3(13f, 1f, 9f),
                        UV = new Vector2(16f, 24f),
                    });
                })
                .AddElement("tail", element => {
                    element.Translate = new Vector3(0.5f, -7f, -1f);
                    element.MirrorTexU = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 5f, 1f),
                        Size = new Vector3(3f, 2f, 6f),
                        UV = new Vector2(3f, 20f),
                    });
                })
                .AddElement("tail2", element => {
                    element.Translate = new Vector3(0.5f, -6.5f, -7f);
                    element.MirrorTexU = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-0.5f, 5.5f, 7f),
                        Size = new Vector3(1f, 1f, 6f),
                        UV = new Vector2(4f, 29f),
                    });
                });
        }
    }
}
