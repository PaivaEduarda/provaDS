import "./Card.css";

export default function Card(props) {
  return (
    <div className="card">
      <h1>Nome: {props.nome}</h1>
      <h2>Espécie: {props.especie}</h2>
      <h2>Casa: {props.casa}</h2>
      <h2>Ator: {props.ator}</h2>
      <img src={"imagens/" + props.imagem} />
    </div>
  );
}
