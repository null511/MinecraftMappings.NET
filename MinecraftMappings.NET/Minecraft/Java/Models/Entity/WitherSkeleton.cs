using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class WitherSkeleton : JavaEntityModel
    {
        public WitherSkeleton() : base("Wither Skeleton")
        {
            AddVersion("wither_skeleton", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("head", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 24f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("headwear", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 24f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = new Vector2(32f, 0f),
                        Inflate = 0.25f,
                    });
                })
                .AddElement("body", element => {
                    element.Translate = new Vector3(0f, -24f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 12f, -2f),
                        Size = new Vector3(8f, 12f, 4f),
                        UV = new Vector2(16f, 16f),
                    });
                })
                .AddElement("left_arm", element => {
                    element.Translate = new Vector3(5f, -22f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-6f, 12f, -1f),
                        Size = new Vector3(2f, 12f, 2f),
                        UV = new Vector2(40f, 16f),
                    });
                })
                .AddElement("right_arm", element => {
                    element.Translate = new Vector3(-5f, -22f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 12f, -1f),
                        Size = new Vector3(2f, 12f, 2f),
                        UV = new Vector2(40f, 16f),
                    });
                })
                .AddElement("left_leg", element => {
                    element.Translate = new Vector3(2f, -12f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 0f, -1f),
                        Size = new Vector3(2f, 12f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("right_leg", element => {
                    element.Translate = new Vector3(-2f, -12f, 0f);

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 0f, -1f),
                        Size = new Vector3(2f, 12f, 2f),
                        UV = new Vector2(0f, 16f),
                    });
                });
        }
    }
}
