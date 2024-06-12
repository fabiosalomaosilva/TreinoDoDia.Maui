using Google.Cloud.Firestore;
using TreinoDoDia.Maui.Services.Interfaces;

namespace TreinoDoDia.Maui.Services;

public class FirestoreData<T> : IFirestoreData<T> where T : class
{
    private readonly FirestoreDb _firestoreDb;
    private readonly string _collectionName;

    public FirestoreData(string collectionName)
    {
        var basePath = AppContext.BaseDirectory;

        var path = Path.Combine(basePath, "Config", "google-services.json");
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
        _firestoreDb = FirestoreDb.Create("treino-do-dia-768e8");
        _collectionName = collectionName;
    }

    public async Task AddAsync(T entity)
    {
        var collection = _firestoreDb.Collection(_collectionName);
        await collection.AddAsync(entity);
    }

    public async Task<T?> GetAsync(string id)
    {
        var document = _firestoreDb.Collection(_collectionName).Document(id);
        var snapshot = await document.GetSnapshotAsync();
        return snapshot.Exists ? snapshot.ConvertTo<T>() : null;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        var collection = _firestoreDb.Collection(_collectionName);
        var snapshot = await collection.GetSnapshotAsync();
        return snapshot.Documents.Select(doc => doc.ConvertTo<T>()).ToList();
    }

    public async Task UpdateAsync(string id, T entity)
    {
        var document = _firestoreDb.Collection(_collectionName).Document(id);
        await document.SetAsync(entity, SetOptions.MergeAll);
    }

    public async Task DeleteAsync(string id)
    {
        var document = _firestoreDb.Collection(_collectionName).Document(id);
        await document.DeleteAsync();
    }
}