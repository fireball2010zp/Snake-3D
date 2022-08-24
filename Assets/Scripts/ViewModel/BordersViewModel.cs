using UnityEngine.SceneManagement;

namespace Snake
{
    public sealed class BordersViewModel : IBordersViewModel
    {
        public void BordersTrigger()
        {
            SceneManager.LoadScene(0);
        }
    }
}
