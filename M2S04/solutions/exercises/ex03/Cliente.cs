using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise03;

public class Cliente
{
    private String? _nome;
    private String? _cpf;

    public Cliente(string? nome, string? cpf) {
      _nome = nome;
      _cpf = cpf;
    }

    public String? Nome() {
      return _nome;
    }

    public String? Cpf() {
      return _cpf;
    }
}
