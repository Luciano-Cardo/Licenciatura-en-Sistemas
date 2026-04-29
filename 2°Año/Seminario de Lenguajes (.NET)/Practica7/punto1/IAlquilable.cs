namespace punto1;

public interface IAlquilable
{
    void SeAlquilaA(Persona p);
    void SeDevuelvePor(Persona p);
}

public interface IVendible
{
    void SeVende(Persona p);
}

public interface ILavable
{
    void Lavar();
    void Secar();
}

public interface IReciclable
{
    void Reciclar();
}

public interface IAtendible
{
    void Atender();
}