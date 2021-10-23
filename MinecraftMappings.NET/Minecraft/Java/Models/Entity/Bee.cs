using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Bee : JavaEntityModel
    {
        public Bee() : base("Bee")
        {
            AddVersion("bee", "1.15")
                .WithTextureSize(64, 64)
                .AddElement("torso", element => {
                    element.Translate = new Vector3(0f, 5f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 2f, -5f),
                        Size = new Vector3(7f, 7f, 10f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("stinger", element => {
                    element.Translate = new Vector3(0f, -5f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 5f, 5f),
                        Size = new Vector3(0f, 1f, 2f),
                        UV = new Vector2(24f, 7f),
                    });
                })
                .AddElement("right_antenna", element => {
                    element.Translate = new Vector3(0f, 7f, -5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1.5f, 7f, -8f),
                        Size = new Vector3(1f, 2f, 3f),
                        UV = new Vector2(2f, 3f),
                    });
                })
                .AddElement("left_antenna", element => {
                    element.Translate = new Vector3(0f, 7f, -5f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 7f, -8f),
                        Size = new Vector3(1f, 2f, 3f),
                        UV = new Vector2(2f, 0f),
                    });
                })
                .AddElement("front_legs", element => {
                    element.Translate = new Vector3(1.5f, 2f, -2f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 0f, -2f),
                        Size = new Vector3(3f, 2f, 0f),
                        UV = new Vector2(28f, 1f),
                    });
                })
                .AddElement("middle_legs", element => {
                    element.Translate = new Vector3(1.5f, 2f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 0f, 0f),
                        Size = new Vector3(5f, 2f, 0f),
                        UV = new Vector2(27f, 3f),
                    });
                })
                .AddElement("back_legs", element => {
                    element.Translate = new Vector3(1.5f, 2f, 2f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 0f, 2f),
                        Size = new Vector3(5f, 2f, 0f),
                        UV = new Vector2(27f, 5f),
                    });
                })
                .AddElement("right_wing", element => {
                    element.Translate = new Vector3(-1.5f, -9f, 3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1.5f, 9f, -3f),
                        Size = new Vector3(9f, 0f, 6f),
                        UV = new Vector2(0f, 18f),
                    });
                })
                .AddElement("left_wing", element => {
                    element.Translate = new Vector3(1.5f, -9f, 3f);
                    element.MirrorUVX = true;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-10.5f, 9f, -3f),
                        Size = new Vector3(9f, 0f, 6f),
                        UV = new Vector2(0f, 18f),
                    });
                });
        }
    }
}
