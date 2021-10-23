using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Cow : JavaEntityModel
    {
        public Cow() : base("Cow")
        {
            AddVersion("cow", "1.0.0")
                //.WithPath("block/cow")
                .WithTextureSize(64, 32)
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, 19f, 2f);
                    element.RotationAngleX = 270;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 11f, -5f),
                        Size = new Vector3(12f, 18f, 10f),
                        UV = new Vector2(18f, 4f),
                    });
                })
                .AddElement("utter", element => {
                    element.Translate = new Vector3(0f, 19f, 2f);
                    element.RotationAngleX = 270;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 11f, -6f),
                        Size = new Vector3(4f, 6f, 1f),
                        UV = new Vector2(52f, 0f),
                    });
                })
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, 20f, -8f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 16f, -14f),
                        Size = new Vector3(8f, 8f, 6f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("left_horn", element => {
                    element.Translate = new Vector3(0f, 20f, -8f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 22f, -12f),
                        Size = new Vector3(1f, 3f, 1f),
                        UV = new Vector2(22f, 0f),
                    });
                })
                .AddElement("right_horn", element => {
                    element.Translate = new Vector3(0f, 20f, -8f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 22f, -12f),
                        Size = new Vector3(1f, 3f, 1f),
                        UV = new Vector2(22f, 0f),
                    });
                })
                .AddElement("leg1", element => {
                    element.Translate = new Vector3(-4f, 12f, 7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(2f, 0f, 5f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Translate = new Vector3(4f, 12f, 7f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 0f, 5f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Translate = new Vector3(-4f, 12f, -6f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(2f, 0f, -7f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Translate = new Vector3(4f, 12f, -6f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 0f, -7f),
                        Size = new Vector3(4f, 12f, 4f),
                        UV = new Vector2(0f, 16f),
                    });
                });
        }
    }
}
