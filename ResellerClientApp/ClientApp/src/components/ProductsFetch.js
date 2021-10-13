import React, { Component } from 'react';

export class ProductsFetch extends Component {
  static displayName = ProductsFetch.name;

  constructor(props) {
    super(props);
    this.state = { products: [], prices: [], loading: true };
  }

  componentDidMount() {
    this.populateProductsData();
    this.populatePricesData();
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
              <td>{product.productName}</td>
              <td>{product.netValue}</td>
              <td>{product.taxRate}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  static renderPricesTable(prices) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Regular net price</th>
            <th>Discount net price</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>{prices.regularPrice}</td>
            <td>{prices.discountPrice}</td>
          </tr>
        </tbody>
      </table>
    );
  }

  render() {
    let productsContents = this.state.loading
      ? <p><em>Loading...</em></p>
      : ProductsFetch.renderProductsTable(this.state.products);

    let pricesContents = this.state.loading
      ? <p><em>Loading...</em></p>
      : ProductsFetch.renderPricesTable(this.state.prices);

    return (
      <div>
        <h1 id="tabelLabel" >Products</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {productsContents}
        {pricesContents}
      </div>
    );
  }

  async populateProductsData() {
    const productsResponse = await fetch('product');
    const productsData = await productsResponse.json();
    this.setState({ products: productsData, loading: false });
  }

  async populatePricesData() {
    const pricesResponse = await fetch('product/prices');
    const pricesData = await pricesResponse.json();
    this.setState({ prices: pricesData, loading: false });
  }
}
