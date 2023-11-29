/* 
* Singleton (생성 패턴)
* - 인스턴스를 오직 한 개만 제공하여야 할 때 사용한다.
* - 전역 변수를 대체할 때 사용한다.
*/

/* 
 * "double check lock" 기법
 * - 멀티쓰레드 환경에서 안전하고, lazy initialization을 가능케 한다.
 */
class Singleton
{
    private Singleton() { }

    private static Singleton? _instance = null;
    private static readonly object _instanceLock = new();

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            lock (_instanceLock)
            {
                _instance ??= new Singleton();
            }
        }

        return _instance;
    }
}