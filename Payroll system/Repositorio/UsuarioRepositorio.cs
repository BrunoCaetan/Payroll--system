/*using Payroll_system.Data;
using Payroll_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Payroll_system.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly object _bancoContext;

        private readonly BancoContent_context;
public UsuarioRepositorio(BancoContent bancoContent)
        {
            this._bancoContext bancoContent;
        }
        public UsuarioModel BuscarPorID(int id)
        {
            return _bancoContext.Usuario.FirstOrDefault(x => x.Id == id);
        }
        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }
            public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }
        public UsuarioModel Atualizar(UsuarioModel contato)
        {
            UsuarioModel usuarioDB = BuscarPorID(usuario.Id);

            if (usuarioDB null) throw new Exception("Houve um erro na atualização do usuário!");

            usuarioDB.Nome = usuario.Nome;
            usuarioDB.Email usuario. Email;
            usuarioDB.Login = usuario.Login;

            _bancoContext.Usuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();
            return usuarioDB;
        }
        public bool Apagar(int id)
        {
            UsuarioModel usuarioDB BuscarPorID(id);

            if (usuarioDB == null) throw new Exception("Houve um erro na deleção do contato!");
            _bancoContext.Usuarios.Remove(usuarioDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }*/