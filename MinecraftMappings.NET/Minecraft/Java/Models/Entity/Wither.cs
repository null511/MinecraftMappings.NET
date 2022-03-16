using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Wither : JavaEntityModel
    {
        public Wither() : base("Wither")
        {
            AddVersion("wither", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("body1", element => {
                    element.Part = "body1";
                    element.Translate = new Vector3(0f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-10f, 17.1f, -0.5f),
                        Size = new Vector3(20f, 3f, 3f),
                        UV = new Vector2(0f, 16f),
                    });
                })
                .AddElement("body2", element => {
                    element.Part = "body2";
                    element.Translate = new Vector3(-3f, -17.1f, 0.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 7.1f, -0.5f),
                        Size = new Vector3(3f, 10f, 3f),
                        UV = new Vector2(0f, 22f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 13.6f, 0f),
                        Size = new Vector3(11f, 2f, 2f),
                        UV = new Vector2(24f, 22f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 11.1f, 0f),
                        Size = new Vector3(11f, 2f, 2f),
                        UV = new Vector2(24f, 22f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 8.6f, 0f),
                        Size = new Vector3(11f, 2f, 2f),
                        UV = new Vector2(24f, 22f),
                    });
                })
                .AddElement("body3", element => {
                    element.Part = "body3";
                    element.Translate = new Vector3(-3f, -7.1f, 0.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 1.1f, -0.5f),
                        Size = new Vector3(3f, 6f, 3f),
                        UV = new Vector2(12f, 22f),
                    });
                })
                .AddElement("head1", element => {
                    element.Part = "head1";
                    element.Translate = new Vector3(-1f, -24f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 20f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("head2", element => {
                    element.Part = "head2";
                    element.Translate = new Vector3(-9f, -20f, 1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(6f, 18f, -4f),
                        Size = new Vector3(6f, 6f, 6f),
                        UV = new Vector2(32f, 0f),
                    });
                })
                .AddElement("head3", element => {
                    element.Part = "head3";
                    element.Translate = new Vector3(9f, -20f, 1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-12f, 18f, -4f),
                        Size = new Vector3(6f, 6f, 6f),
                        UV = new Vector2(32f, 0f),
                    });
                });
        }
    }
}
