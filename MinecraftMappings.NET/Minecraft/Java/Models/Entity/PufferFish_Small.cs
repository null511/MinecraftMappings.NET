using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class PufferFish_Small : JavaEntityModel
    {
        public PufferFish_Small() : base("PufferFish, Small")
        {
            AddVersion("puffer_fish_small", "1.0.0")
                .WithTextureSize(32, 32)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 0f, -1.5f),
                        Size = new Vector3(3f, 2f, 3f),
                        UV = new Vector2(0f, 27f),
                    });
                })
                .AddElement("tail", element => {
                    element.Part = "tail";
                    element.Translate = new Vector3(0f, -1f, -1.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 1f, 1.5f),
                        Size = new Vector3(3f, 0f, 3f),
                        UV = new Vector2(-3f, 0f),
                    });
                })
                .AddElement("fin_right", element => {
                    element.Part = "fin_right";
                    element.Translate = new Vector3(-1.5f, -1f, 1.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.5f, 1f, -1.49f),
                        Size = new Vector3(1f, 0f, 2f),
                        UV = new Vector2(25f, 0f),
                    });
                })
                .AddElement("fin_left", element => {
                    element.Part = "fin_left";
                    element.Translate = new Vector3(1.5f, -1f, 1.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2.5f, 1f, -1.49f),
                        Size = new Vector3(1f, 0f, 2f),
                        UV = new Vector2(25f, 0f),
                    });
                })
                .AddElement("eye_right", element => {
                    element.Part = "eye_right";
                    element.Translate = new Vector3(0f, -3f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1.5f, 2f, -1.5f),
                        Size = new Vector3(1f, 1f, 1f),
                        UV = new Vector2(28f, 6f),
                    });
                })
                .AddElement("eye_left", element => {
                    element.Part = "eye_left";
                    element.Translate = new Vector3(0f, -3f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0.5f, 2f, -1.5f),
                        Size = new Vector3(1f, 1f, 1f),
                        UV = new Vector2(24f, 6f),
                    });
                });
        }
    }
}
