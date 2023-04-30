using Church.Contexts.SharedContext.Enums;
using Church.Contexts.SharedContext.ValueObjects;

namespace Church.Contexts.SharedContext.Entities;

public class Document : Entity
{
    #region Public Constructors

    /// <summary>
    /// Create a new instance of Document with default configuration
    /// </summary>
    public Document() => Tracker = new Tracker("Criação do cadastro de documentos.");

    public Document(string documentNumber, EDocumentType documentType, bool isDeleted, Person person)
    {
        DocumentNumber = documentNumber;
        DocumentType = documentType;
        IsDeleted = isDeleted;
        Person = person;
        Tracker = new Tracker("Criação do cadastro de documentos.");
    }

    #endregion

    #region Public Properties

    public string DocumentNumber { get; private set; } = string.Empty;
    public EDocumentType DocumentType { get; private set; } = EDocumentType.RG;
    public bool IsDeleted { get; private set; }
    public Person Person { get; private set; } = null!;
    public Tracker Tracker { get; } = null!;

    #endregion

    #region Public Methods

    public void ChangeDocument(
        string documentNumber,
        EDocumentType documentType, 
        Person person)
    {
        DocumentNumber = documentNumber;
        DocumentType = documentType;
        Person = person;
        Tracker.Update("Informações atualizadas.");
    }

    public void Delete()
    {
        IsDeleted = true;
        Tracker.Update("Documento excluído.");
    }

    #endregion
}