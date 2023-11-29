<h3>Add a product</h3>
<form method="post" action="{{ route('product.store') }}">
    @csrf
    <input type="text" name="name" placeholder="Name" value="{{ old('name') }}">
    <input type="text" name="price" placeholder="Price" value="{{ old('price') }}">
    <input type="text" name="description" placeholder="Description" value="{{ old('description') }}">
    <input type="submit" value="Add">
</form>
