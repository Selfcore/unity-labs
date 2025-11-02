namespace ProjectAssets.Scripts.Architecture.MVC
{
    public sealed class PlayerModel
    {
        public float Speed { get; set; } = 5f;
        public float JumpForce { get; set; } = 20f;
        public bool IsGrounded { get; set; }
    }
}