using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Ghast : JavaEntityModel
    {
        public Ghast() : base("Ghast")
        {
            AddVersion("ghast", "1.2.0")
                .WithTextureSize(64, 32)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -20f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, 12f, -8f),
                        Size = new Vector3(16f, 16f, 16f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle1", element => {
                    element.Part = "tentacle1";
                    element.Translate = new Vector3(-3.7f, -13f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2.7f, 5f, -6f),
                        Size = new Vector3(2f, 8f, 2f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle2", element => {
                    element.Part = "tentacle2";
                    element.Translate = new Vector3(1.3f, -13f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-7.3f, 4f, -6f),
                        Size = new Vector3(2f, 9f, 2f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle3", element => {
                    element.Part = "tentacle3";
                    element.Translate = new Vector3(6.3f, -13f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.3f, 0f, -6f),
                        Size = new Vector3(2f, 13f, 2f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle4", element => {
                    element.Part = "tentacle4";
                    element.Translate = new Vector3(-6.3f, -13f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(5.3f, 2f, -1f),
                        Size = new Vector3(2f, 11f, 2f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle5", element => {
                    element.Part = "tentacle5";
                    element.Translate = new Vector3(-1.3f, -13f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0.3f, 2f, -1f),
                        Size = new Vector3(2f, 11f, 2f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle6", element => {
                    element.Part = "tentacle6";
                    element.Translate = new Vector3(3.7f, -13f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4.7f, 3f, -1f),
                        Size = new Vector3(2f, 10f, 2f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle7", element => {
                    element.Part = "tentacle7";
                    element.Translate = new Vector3(-3.7f, -13f, -5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2.7f, 1f, 4f),
                        Size = new Vector3(2f, 12f, 2f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle8", element => {
                    element.Part = "tentacle8";
                    element.Translate = new Vector3(1.3f, -13f, -5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-7.3f, 1f, 4f),
                        Size = new Vector3(2f, 12f, 2f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("tentacle9", element => {
                    element.Part = "tentacle9";
                    element.Translate = new Vector3(6.3f, -13f, -5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.3f, 4f, 4f),
                        Size = new Vector3(2f, 9f, 2f),
                        UV = Vector2.Zero,
                    });
                });
        }
    }
}
