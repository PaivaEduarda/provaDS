import React, { Component } from "react";
import Card from "../Card/Card";
import "./CrudPersonagens.css";
import axios from "axios";

const urlApi = "http://localhost:5169/api/Hp";

const stateInicial = { listaPersonagens: [] };

export default class CrudPersonagens extends Component {
  state = { ...stateInicial };

  // quando o componente é montado (a página é carregada)
  componentDidMount() {
    axios.get(urlApi).then((resposta) => {
      this.setState({ listaPersonagens: resposta.data });
    });
  }

  render() {
    return (
      <div>
        {this.state.listaPersonagens.map((personagem) => {
          return (
            <Card
              imagem={personagem.imagem}
              nome={personagem.nome}
              especie={personagem.especie}
              casa={personagem.casa}
              ator={personagem.ator}
            />
          );
        })}
      </div>
    );
  }
}
