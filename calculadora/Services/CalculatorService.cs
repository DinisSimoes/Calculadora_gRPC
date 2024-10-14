

using Grpc.Core;

namespace calculadora.Services
{
    public class CalculatorService : Calculator.CalculatorBase
    {
        public override Task<CalculatorResponse> Add(CalculatorRequest request, ServerCallContext context)
        {
            var result = request.Number1 + request.Number2;
            return Task.FromResult(new CalculatorResponse { Result = result });
        }

        public override Task<CalculatorResponse> Subtract(CalculatorRequest request, ServerCallContext context)
        {
            var result = request.Number1 - request.Number2;
            return Task.FromResult(new CalculatorResponse { Result = result });
        }

        public override Task<CalculatorResponse> Multiply(CalculatorRequest request, ServerCallContext context)
        {
            var result = request.Number1 * request.Number2;
            return Task.FromResult(new CalculatorResponse { Result = result });
        }

        public override Task<CalculatorResponse> Divide(CalculatorRequest request, ServerCallContext context)
        {
            var result = request.Number1 / request.Number2;
            return Task.FromResult(new CalculatorResponse { Result = result });
        }
    }
}
