import React, { Component } from 'react';

export class ProductsFetch extends Component {
  static displayName = ProductsFetch.name;

  constructor(props) {
    super(props);
    this.state = { products: [], loading: true };
  }

  componentDidMount() {
    this.populateProductsData();
  }

  static renderProductsTable(products) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Product Name</th>
            <th>Net Value</th>
            <th>Tax rate</th>
          </tr>
        </thead>
        <tbody>
          {products.map(product =>
            <tr key={product.productName}>
              <td>{product.netValue}</td>
              <td>{product.taxRate}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : ProductsFetch.renderProductsTable(this.state.products);

    return (
      <div>
        <h1 id="tabelLabel" >Products</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateProductsData() {
    const response = await fetch('product');
    const data = await response.json();
    this.setState({ products: data, loading: false });
  }
}
