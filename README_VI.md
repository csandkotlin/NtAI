
# Not A AI (NtAI)
[![.NET Core Desktop](https://github.com/csandkotlin/NtAI/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/csandkotlin/NtAI/actions/workflows/dotnet-desktop.yml)
[![.NET Core Desktop](https://github.com/csandkotlin/NtAI/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/csandkotlin/NtAI/actions/workflows/dotnet-desktop.yml)

---

[View in English!](./README.md)

## Nó là gì?

**NtAI** là một chatbot **dựa trên quy tắc** được viết bằng C#.  
Nó sử dụng **so khớp mẫu (pattern matching)** để hiểu và phản hồi tin nhắn của người dùng — hoàn toàn không dùng AI, không học máy, chỉ đơn giản là logic có thể dự đoán được.

> Phù hợp để học tập, tạo nguyên mẫu hoặc nhúng vào các công cụ mà chỉ cần phản hồi mang tính xác định là đủ.

## Cách sử dụng

Nhập tin nhắn của bạn, chatbot sẽ trả lời bằng cách so khớp đầu vào của bạn với các mẫu được định nghĩa trước.

## Tự sao chép và xây dựng

### Yêu cầu

- **Git** – để sao chép kho lưu trữ  
- **.NET SDK** – phiên bản tối thiểu **8.0** (để xây dựng và chạy)

### Các bước thực hiện

**1. Sao chép kho lưu trữ này**

```bash
git clone https://github.com/realmg51-cpu/NtAI.git
```

2. Xây dựng dự án

```bash
cd src/main
dotnet build
```

3. Chạy (không bắt buộc)

```bash
dotnet run
```

### Ví dụ về so khớp mẫu

| Bạn nói | Bot có thể trả lời |
|---------|---------------------|
| Xin chào | Chào bạn! Tôi có thể giúp gì được không? |
| AI là gì? | AI là… nhưng tôi dựa trên quy tắc, không phải AI. |
| Tôi thích lập trình | Tôi cũng vậy! C# rất tuyệt phải không nào? |

## Giấy phép

Dự án này được cấp phép theo Giấy phép MIT.
Xem tệp [LICENSE](./LICENSE) để biết thêm chi tiết.
