public interface IApiRequestBuilder<TGetBuilder, TPostBuilder> : 
    IHasUrlBuilder2, 
    IHasGetMethodBuilder2<TGetBuilder>, 
    IHasPostMethodBuilder2<TPostBuilder>
{
}
