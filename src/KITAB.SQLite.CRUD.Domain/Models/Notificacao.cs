﻿namespace KITAB.SQLite.CRUD.Domain.Models
{
    public class Notificacao
    {
        public string Mensagem { get; }

        public Notificacao(string p_mensagem)
        {
            Mensagem = p_mensagem;
        }
    }
}
