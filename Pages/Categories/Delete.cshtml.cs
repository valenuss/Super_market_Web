@page
@model SupermarketWEB.Pages.Categories.DeleteModel
@{
	ViewData["Title"] = "Delete";
}

<h1>Delete</h1>

<h3>Are you sure you want to delete this?</h3>
<div>
	<h4>Category</h4>
	<hr />
	<dl class="row">
		<dt class="col-sm-2">
			@Html.DisplayNameFor(model => model.Category.Name)
		</dt>
		<dd class="col-sm-10">
			@Html.DisplayNameFor(model => model.Category.Name)
		</dd>
		<dt class="col-sm-2">
			@Html.DisplayNameFor(model => model.Category.Description)
		</dt>
		<dd class="col-sm-10">
			@Html.DisplayNameFor(model => model.Category.Description)
		</dd>
	</dl>

	<form method="post">
		<input type="hidden" asp-for="Category.Id" />
		<input type="submit" value="Delete" class="btn btn-danger" />
		<a asp-page="./Index" class="btn btn-primary">Back to List</a>
	</form>
</div>@page
@model SupermarketWEB.Pages.Categories.DeleteModel
@{
	ViewData["Title"] = "Delete";
}

<h1>Delete</h1>

<h3>Are you sure you want to delete this?</h3>
<div>
	<h4>Category</h4>
	<hr />
	<dl class="row">
		<dt class="col-sm-2">
			@Html.DisplayNameFor(model => model.Category.Name)
		</dt>
		<dd class="col-sm-10">
			@Html.DisplayNameFor(model => model.Category.Name)
		</dd>
		<dt class="col-sm-2">
			@Html.DisplayNameFor(model => model.Category.Description)
		</dt>
		<dd class="col-sm-10">
			@Html.DisplayNameFor(model => model.Category.Description)
		</dd>
	</dl>

	<form method="post">
		<input type="hidden" asp-for="Category.Id" />
		<input type="submit" value="Delete" class="btn btn-danger" />
		<a asp-page="./Index" class="btn btn-primary">Back to List</a>
	</form>
</div>