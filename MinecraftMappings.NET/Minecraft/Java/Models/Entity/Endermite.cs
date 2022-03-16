using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Endermite : JavaEntityModel
    {
        public Endermite() : base("Endermite")
        {
            AddVersion("endermite", "1.8")
                .WithTextureSize(64, 32)
                .AddElement("body1", element => {
                    element.Part = "body1";
                    element.Translate = new Vector3(0f, -3f, 3.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 0f, -4.5f),
                        Size = new Vector3(4f, 3f, 2f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("body2", element => {
                    element.Part = "body2";
                    element.Translate = new Vector3(0f, -4f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 0f, -2.5f),
                        Size = new Vector3(6f, 4f, 5f),
                        UV = new Vector2(0f, 5f),
                    });
                })
                .AddElement("body3", element => {
                    element.Part = "body3";
                    element.Translate = new Vector3(0f, -3f, -3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 0f, 2.5f),
                        Size = new Vector3(3f, 3f, 1f),
                        UV = new Vector2(0f, 14f),
                    });
                })
                .AddElement("body4", element => {
                    element.Part = "body4";
                    element.Translate = new Vector3(0f, -2f, -4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-0.5f, 0f, 3.5f),
                        Size = new Vector3(1f, 2f, 1f),
                        UV = new Vector2(0f, 18f),
                    });
                });
        }
    }
}
