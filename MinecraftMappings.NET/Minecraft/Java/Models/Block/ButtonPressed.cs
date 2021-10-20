using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ButtonPressed : JavaBlockModel
    {
        public ButtonPressed() : base("Button, Pressed")
        {
            AddVersion("button_pressed", "1.0.0")
                .WithPath("models/block")
                .AddElement(element => {
                    element.From = new Vector3(5f, 0f, 6f);
                    element.To = new Vector3(11f, 1f, 10f);
                    element.FaceUp = new ModelFace {
                        UV = UVMap(5f, 10f, 11f, 6f),
                        Texture = "#texture",
                    };
                    element.FaceDown = new ModelFace {
                        UV = UVMap(5f, 6f, 11f, 10f),
                        Texture = "#texture",
                    };
                    element.FaceNorth = new ModelFace {
                        UV = UVMap(5f, 14f, 11f, 15f),
                        Texture = "#texture",
                    };
                    element.FaceSouth = new ModelFace {
                        UV = UVMap(5f, 14f, 11f, 15f),
                        Texture = "#texture",
                    };
                    element.FaceWest = new ModelFace {
                        UV = UVMap(6f, 14f, 10f, 15f),
                        Texture = "#texture",
                    };
                    element.FaceEast = new ModelFace {
                        UV = UVMap(6f, 14f, 10f, 15f),
                        Texture = "#texture",
                    };
                });
        }
    }
}
