# Pequeno Ladrão de Carros

Bem-vindo ao "Pequeno Ladrão de Carros", uma paródia divertida e irreverente do famoso Grand Theft Auto (GTA)! Este jogo leva você a uma jornada hilária através de uma cidade vibrante, onde missões absurdas, personagens peculiares e situações inusitadas garantem uma experiência de jogo única.

## Sobre o Jogo

Inspirado pelo mundo caótico e repleto de ação de GTA, "Pequeno Ladrão de Carros" oferece uma visão cômica e exagerada dos clássicos jogos de ação e aventura. Com um toque de humor e uma pitada de sarcasmo, este jogo satiriza os clichês e exageros do universo dos games, proporcionando horas de entretenimento e risadas.

## Características

- **Missões Absurdas**: Enfrente desafios hilariantes e situações bizarras em cada missão.
- **Personagens Peculiares**: Interaja com uma série de personagens únicos e divertidos.
- **Humor e Sarcasmo**: Uma abordagem cômica que satiriza os clichês do gênero.
- **Mundo Vibrante**: Explore uma cidade cheia de vida e repleta de detalhes engraçados.

## Como Jogar

1. **Instale o Jogo**: Baixe e instale "Pequeno Ladrão de Carros" no seu dispositivo.
2. **Inicie a Aventura**: Comece sua jornada na cidade, aceitando missões e explorando o ambiente.
3. **Divirta-se**: Aproveite as situações cômicas e as missões absurdas enquanto se diverte com a paródia do universo de GTA.

## COMANDOS BASICOS
1. W A S D - Move o personagem e Veiculos 
2. Q - Muda o Dia para Noite

## Prints 

### Menu
![image](https://github.com/LeonardoAdolfo/ProjetoGTA2/assets/78151545/64e2fa1f-7da7-4199-8513-606ac98d8130)

### Cidade
![image](https://github.com/LeonardoAdolfo/ProjetoGTA2/assets/78151545/e9cfbe4a-7c8d-4bc4-b190-629c3b8c47ed)

### Tela do Jogador
![image](https://github.com/LeonardoAdolfo/ProjetoGTA2/assets/78151545/454cd3dd-69d9-4a3d-a3d0-5d1f9ab58e88)

## Video Gameplay

## Funcões 

### Geração de objetos aleatorios 

```csharp
using UnityEngine;

public class CollectionableController : MonoBehaviour
{
    public GameObject collectiblePrefab; // Prefab of the collectible object
    public GameObject player; // Reference to the player object
    public float spawnRadius = 1f; // Radius around the player within which to spawn collectibles
    public float spawnInterval = 2f; // Time interval between spawns

    void Start()
    {
        InvokeRepeating("SpawnCollectible", 1f, spawnInterval); // Start spawning collectibles
    }

    void SpawnCollectible()
    {
        // Generate a random position within the specified radius
        Vector3 randomPosition = Random.insideUnitSphere * spawnRadius;
        // Ensure the collectible spawns above 0 and below 2 units relative to the player's position
        float spawnY = Random.Range(0f, 1f);
        Vector3 spawnPosition = new Vector3(player.transform.position.x + randomPosition.x, player.transform.position.y + spawnY, player.transform.position.z + randomPosition.z);

        Instantiate(collectiblePrefab, spawnPosition, Quaternion.identity); // Instantiate the collectible
    }
}
```

#### Descrição

Este script Unity `CollectionableController` controla o aparecimento de objetos colecionáveis ao redor do jogador. Os colecionáveis são gerados a intervalos regulares dentro de um raio específico ao redor da posição do jogador.

#### Uso

1. **Prefab do Colecionável**: Certifique-se de ter um prefab do objeto colecionável e atribua-o à variável `collectiblePrefab` no inspetor do Unity.
2. **Objeto do Jogador**: Atribua o objeto do jogador à variável `player` no inspetor.
3. **Parâmetros de Spawn**: Ajuste o `spawnRadius` para definir o raio dentro do qual os colecionáveis aparecerão e o `spawnInterval` para definir a frequência de aparecimento.

#### Imagem

![image](https://github.com/LeonardoAdolfo/ProjetoGTA2/assets/78151545/45c38beb-44ce-4f61-8a42-9379afecd96c)


### Interação com o objeto Player
```csharp
using UnityEngine;

public class PlayerControllerSpawn : MonoBehaviour
{
    public ScoreManager scoreManager; // Reference to the ScoreManager

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("OnTriggerEnter called");
        if (collision.gameObject.CompareTag("Collectible"))
        {
            if (scoreManager == null)
            {
                Debug.LogError("ScoreManager is not assigned!");
                return;
            }

            scoreManager.IncreaseScore(1); // Increase the score by 1
            Debug.Log("Collectible collected! Score: " + scoreManager.GetScore());
            Destroy(collision.gameObject);
        }
    }
}
```
#### Descrição 

Quando o player ou objeto "Player" rela no Objeto Colecionavel, ele incrementa 1 ponto ao score e destroy o objeto

### Adiciondo Score

```csharp
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text component
    private int score = 0;

    void Start()
    {
        // Initialize the score text
        UpdateScoreText();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
```

#### Descrição

Nesse codigo mudamos o texto do canva selecionado e mudamos para o score, para isso integramos 1 canva com o texto e um objeto para realizar a função de mudanca de valor 

### Imagens

![image](https://github.com/LeonardoAdolfo/ProjetoGTA2/assets/78151545/f6539cf7-a50f-4aba-a2e8-fbfb7f40d820)

![image](https://github.com/LeonardoAdolfo/ProjetoGTA2/assets/78151545/adc1b25b-d7fa-4d9c-9216-fc9b31d349df)

## Video

