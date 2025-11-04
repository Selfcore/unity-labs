namespace ProjectAssets.Scripts.Architecture.MVC
{
    public sealed class PlayerModel
    {
        public float Speed { get; set; } = 50f;
        public float JumpForce { get; set; } = 60f;
        public bool IsGrounded { get; set; }
    }
}