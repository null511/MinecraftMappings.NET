using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Axolotl : JavaEntityModel
    {
        public Axolotl() : base("Axolotl")
        {
            AddVersion("axolotl", "1.17")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -6f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 4f, -10f),
                        Size = new Vector3(8f, 5f, 5f),
                        UV = new Vector2(0f, 1f),
                    });
                })
                .AddElement("top_gills", element => {
                    element.Part = "top_gills";
                    element.Translate = new Vector3(0f, -9f, 6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 9f, -6f),
                        Size = new Vector3(8f, 3f, 0f),
                        UV = new Vector2(3f, 37f),
                    });
                })
                .AddElement("left_gills", element => {
                    element.Part = "left_gills";
                    element.Translate = new Vector3(-4f, -6f, 6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(4f, 4f, -6f),
                        Size = new Vector3(3f, 7f, 0f),
                        UV = new Vector2(0f, 40f),
                    });
                })
                .AddElement("right_gills", element => {
                    element.Part = "right_gills";
                    element.Translate = new Vector3(4f, -6f, 6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-7f, 4f, -6f),
                        Size = new Vector3(3f, 7f, 0f),
                        UV = new Vector2(11f, 40f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -6f, -4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 4f, -5f),
                        Size = new Vector3(8f, 4f, 10f),
                        UV = new Vector2(0f, 11f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 4f, -4f),
                        Size = new Vector3(0f, 5f, 9f),
                        UV = new Vector2(2f, 17f),
                    });
                })
                .AddElement("leg4", element => {
                    element.Part = "leg4";
                    element.Translate = new Vector3(3.5f, -5f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5.5f, 0f, -4f),
                        Size = new Vector3(3f, 5f, 0f),
                        UV = new Vector2(2f, 13f),
                    });
                })
                .AddElement("leg2", element => {
                    element.Part = "leg2";
                    element.Translate = new Vector3(3.5f, -5f, -3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5.5f, 0f, 3f),
                        Size = new Vector3(3f, 5f, 0f),
                        UV = new Vector2(2f, 13f),
                    });
                })
                .AddElement("leg3", element => {
                    element.Part = "leg3";
                    element.Translate = new Vector3(-3.5f, -5f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2.5f, 0f, -4f),
                        Size = new Vector3(3f, 5f, 0f),
                        UV = new Vector2(2f, 13f),
                    });
                })
                .AddElement("leg1", element => {
                    element.Part = "leg1";
                    element.Translate = new Vector3(-3.5f, -5f, -3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2.5f, 0f, 3f),
                        Size = new Vector3(3f, 5f, 0f),
                        UV = new Vector2(2f, 13f),
                    });
                })
                .AddElement("tail", element => {
                    element.Part = "tail";
                    element.Translate = new Vector3(0f, -6f, -5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 4f, 5f),
                        Size = new Vector3(0f, 5f, 12f),
                        UV = new Vector2(2f, 19f),
                    });
                });
        }
    }
}
